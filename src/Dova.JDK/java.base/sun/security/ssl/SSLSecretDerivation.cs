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

[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation;", "final")]
public partial class SSLSecretDerivation
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.ssl.SSLKeyDerivation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLSecretDerivation()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLSecretDerivation;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "sha256EmptyDigest", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "sha384EmptyDigest", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "hashAlg", "Lsun/security/ssl/CipherSuite$HashAlg;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "secret", "Ljavax/crypto/SecretKey;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "transcriptHash", "[B"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SSLSecretDerivation", "(Lsun/security/ssl/HandshakeContext;Ljavax/crypto/SecretKey;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createHkdfInfo", "([B[BI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "forContext", "(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLSecretDerivation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deriveKey", "(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;"));
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> sha256EmptyDigest_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> sha384EmptyDigest_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$HashAlg;", "private final")]
	public Dova.JDK.sun.security.ssl.CipherSuite.HashAlg hashAlg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.HashAlg>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "private final")]
	public Dova.JDK.javax.crypto.SecretKey secret_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[B", "private final")]
	public JavaArray<byte> transcriptHash_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLSecretDerivation(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Ljavax/crypto/SecretKey;)V", "")]
	public SSLSecretDerivation(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.javax.crypto.SecretKey arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLSecretDerivation;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([B[BI)[B", "public static")]
	public static JavaArray<byte> createHkdfInfo(JavaArray<byte> arg0, JavaArray<byte> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)Lsun/security/ssl/SSLSecretDerivation;", "")]
	public Dova.JDK.sun.security.ssl.SSLSecretDerivation forContext(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;)Ljavax/crypto/SecretKey;", "public")]
	public Dova.JDK.javax.crypto.SecretKey deriveKey(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "private static final")]
	public partial class SecretSchedule
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SecretSchedule()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsSaltSecret", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsExtBinderKey", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsResBinderKey", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsClientEarlyTrafficSecret", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsEarlyExporterMasterSecret", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsClientHandshakeTrafficSecret", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsServerHandshakeTrafficSecret", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsClientAppTrafficSecret", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsServerAppTrafficSecret", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsExporterMasterSecret", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TlsResumptionMasterSecret", "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "label", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SecretSchedule", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsSaltSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsExtBinderKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsResBinderKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsClientEarlyTrafficSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsEarlyExporterMasterSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsClientHandshakeTrafficSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsServerHandshakeTrafficSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsClientAppTrafficSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsServerAppTrafficSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsExporterMasterSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static final")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule TlsResumptionMasterSecret_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> label_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SecretSchedule(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public SecretSchedule(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "public static")]
		public static Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/SSLSecretDerivation$SecretSchedule;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLSecretDerivation.SecretSchedule>>(ret);
		}
	}
}
