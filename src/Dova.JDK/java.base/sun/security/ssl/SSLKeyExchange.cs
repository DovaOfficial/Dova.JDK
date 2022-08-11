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

[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "final")]
public partial class SSLKeyExchange
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator
	, Dova.JDK.sun.security.ssl.SSLHandshakeBinding
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLKeyExchange()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authentication", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyAgreement", "Lsun/security/ssl/SSLKeyAgreement;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Lsun/security/ssl/SSLKeyAgreement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Lsun/security/ssl/CipherSuite$KeyExchange;Lsun/security/ssl/ProtocolVersion;)Lsun/security/ssl/SSLKeyExchange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Lsun/security/ssl/NamedGroup;)Lsun/security/ssl/SSLKeyExchange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandshakeProducers", "(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRelatedHandshakers", "(Lsun/security/ssl/HandshakeContext;)[Lsun/security/ssl/SSLHandshake;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossessions", "(Lsun/security/ssl/HandshakeContext;)[Lsun/security/ssl/SSLPossession;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandshakeConsumers", "(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;"));
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List authentication_Property
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

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyAgreement;", "private final")]
	public Dova.JDK.sun.security.ssl.SSLKeyAgreement keyAgreement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyAgreement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLKeyExchange(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;Lsun/security/ssl/SSLKeyAgreement;)V", "")]
	public SSLKeyExchange(Dova.JDK.java.util.List arg0, Dova.JDK.sun.security.ssl.SSLKeyAgreement arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/ssl/CipherSuite$KeyExchange;Lsun/security/ssl/ProtocolVersion;)Lsun/security/ssl/SSLKeyExchange;", "static")]
	public static Dova.JDK.sun.security.ssl.SSLKeyExchange valueOf(Dova.JDK.sun.security.ssl.CipherSuite.KeyExchange arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;)Lsun/security/ssl/SSLKeyExchange;", "static")]
	public static Dova.JDK.sun.security.ssl.SSLKeyExchange valueOf(Dova.JDK.sun.security.ssl.NamedGroup arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
	public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;", "public")]
	public JavaArray<Dova.JDK.java.util.Map.Entry> getHandshakeProducers(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)[Lsun/security/ssl/SSLHandshake;", "public")]
	public JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake> getRelatedHandshakers(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)[Lsun/security/ssl/SSLPossession;", "")]
	public JavaArray<Dova.JDK.sun.security.ssl.SSLPossession> createPossessions(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLPossession>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;", "public")]
	public JavaArray<Dova.JDK.java.util.Map.Entry> getHandshakeConsumers(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "private static final")]
	public partial class T12KeyAgreement
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.sun.security.ssl.SSLKeyAgreement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T12KeyAgreement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RSA", "Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RSA_EXPORT", "Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DHE", "Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DHE_EXPORT", "Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ECDH", "Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ECDHE", "Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "possessionGenerator", "Lsun/security/ssl/SSLPossessionGenerator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyAgreementGenerator", "Lsun/security/ssl/SSLKeyAgreementGenerator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Lsun/security/ssl/SSLPossessionGenerator;Lsun/security/ssl/SSLKeyAgreementGenerator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandshakeProducers", "(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRelatedHandshakers", "(Lsun/security/ssl/HandshakeContext;)[Lsun/security/ssl/SSLHandshake;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandshakeConsumers", "(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossession", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement RSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement RSA_EXPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement DHE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement DHE_EXPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement ECDH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement ECDHE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String name_Property
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

		[JniSignatureAttribute("Lsun/security/ssl/SSLPossessionGenerator;", "final")]
		public Dova.JDK.sun.security.ssl.SSLPossessionGenerator possessionGenerator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossessionGenerator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyAgreementGenerator;", "final")]
		public Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator keyAgreementGenerator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T12KeyAgreement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Lsun/security/ssl/SSLPossessionGenerator;Lsun/security/ssl/SSLKeyAgreementGenerator;)V", "private")]
		public T12KeyAgreement(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.sun.security.ssl.SSLPossessionGenerator arg3, Dova.JDK.sun.security.ssl.SSLKeyAgreementGenerator arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "public static")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/SSLKeyExchange$T12KeyAgreement;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLKeyExchange.T12KeyAgreement>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
		public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;", "public")]
		public JavaArray<Dova.JDK.java.util.Map.Entry> getHandshakeProducers(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)[Lsun/security/ssl/SSLHandshake;", "public")]
		public JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake> getRelatedHandshakers(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)[Ljava/util/Map$Entry;", "public")]
		public JavaArray<Dova.JDK.java.util.Map.Entry> getHandshakeConsumers(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;", "public")]
		public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExRSA;", "private static")]
	public partial class SSLKeyExRSA
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExRSA()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExRSA;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExRSA(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExRSA() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExRSA;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExRSAExport;", "private static")]
	public partial class SSLKeyExRSAExport
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExRSAExport()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExRSAExport;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExRSAExport(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExRSAExport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExRSAExport;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHEDSS;", "private static")]
	public partial class SSLKeyExDHEDSS
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExDHEDSS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHEDSS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExDHEDSS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExDHEDSS() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHEDSS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHEDSSExport;", "private static")]
	public partial class SSLKeyExDHEDSSExport
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExDHEDSSExport()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHEDSSExport;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExDHEDSSExport(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExDHEDSSExport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHEDSSExport;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHERSAOrPSS;", "private static")]
	public partial class SSLKeyExDHERSAOrPSS
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExDHERSAOrPSS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHERSAOrPSS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExDHERSAOrPSS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExDHERSAOrPSS() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHERSAOrPSS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHERSA;", "private static")]
	public partial class SSLKeyExDHERSA
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExDHERSA()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHERSA;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExDHERSA(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExDHERSA() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHERSA;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHERSAExport;", "private static")]
	public partial class SSLKeyExDHERSAExport
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExDHERSAExport()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHERSAExport;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExDHERSAExport(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExDHERSAExport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHERSAExport;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHANON;", "private static")]
	public partial class SSLKeyExDHANON
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExDHANON()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHANON;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExDHANON(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExDHANON() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHANON;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHANONExport;", "private static")]
	public partial class SSLKeyExDHANONExport
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExDHANONExport()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHANONExport;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExDHANONExport(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExDHANONExport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExDHANONExport;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHECDSA;", "private static")]
	public partial class SSLKeyExECDHECDSA
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExECDHECDSA()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHECDSA;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExECDHECDSA(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExECDHECDSA() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHECDSA;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHRSA;", "private static")]
	public partial class SSLKeyExECDHRSA
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExECDHRSA()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHRSA;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExECDHRSA(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExECDHRSA() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHRSA;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHEECDSA;", "private static")]
	public partial class SSLKeyExECDHEECDSA
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExECDHEECDSA()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHEECDSA;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExECDHEECDSA(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExECDHEECDSA() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHEECDSA;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHERSAOrPSS;", "private static")]
	public partial class SSLKeyExECDHERSAOrPSS
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExECDHERSAOrPSS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHERSAOrPSS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExECDHERSAOrPSS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExECDHERSAOrPSS() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHERSAOrPSS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHERSA;", "private static")]
	public partial class SSLKeyExECDHERSA
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExECDHERSA()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHERSA;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExECDHERSA(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExECDHERSA() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHERSA;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHANON;", "private static")]
	public partial class SSLKeyExECDHANON
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLKeyExECDHANON()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHANON;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KE", "Lsun/security/ssl/SSLKeyExchange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "private static final")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange KE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLKeyExECDHANON(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLKeyExECDHANON() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$SSLKeyExECDHANON;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange$T13KeyAgreement;", "private static final")]
	public partial class T13KeyAgreement
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLKeyAgreement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static T13KeyAgreement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLKeyExchange$T13KeyAgreement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "namedGroup", "Lsun/security/ssl/NamedGroup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "supportedKeyShares", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/NamedGroup;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Lsun/security/ssl/NamedGroup;)Lsun/security/ssl/SSLKeyExchange$T13KeyAgreement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyDerivation", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPossession", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "private final")]
		public Dova.JDK.sun.security.ssl.NamedGroup namedGroup_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "static final")]
		public static Dova.JDK.java.util.Map supportedKeyShares_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public T13KeyAgreement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;)V", "private")]
		public T13KeyAgreement(Dova.JDK.sun.security.ssl.NamedGroup arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLKeyExchange$T13KeyAgreement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/NamedGroup;)Lsun/security/ssl/SSLKeyExchange$T13KeyAgreement;", "static")]
		public static Dova.JDK.sun.security.ssl.SSLKeyExchange.T13KeyAgreement valueOf(Dova.JDK.sun.security.ssl.NamedGroup arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange.T13KeyAgreement>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLKeyDerivation;", "public")]
		public Dova.JDK.sun.security.ssl.SSLKeyDerivation createKeyDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLPossession;", "public")]
		public Dova.JDK.sun.security.ssl.SSLPossession createPossession(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLPossession>(ret);
		}
	}
}
