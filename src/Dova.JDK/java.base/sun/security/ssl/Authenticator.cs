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

[JniSignatureAttribute("Lsun/security/ssl/Authenticator;", "abstract")]
public partial class Authenticator
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Authenticator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "block", "[B"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)Lsun/security/ssl/Authenticator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Lsun/security/ssl/ProtocolVersion;)Lsun/security/ssl/Authenticator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nullTlsMac", "()Lsun/security/ssl/Authenticator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nullDtlsMac", "()Lsun/security/ssl/Authenticator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "seqNumOverflow", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "seqNumIsHuge", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEpochNumber", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "increaseSequenceNumber", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireAuthenticationBytes", "(BI[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toLong", "([B)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sequenceNumber", "()[B"));
	}

	[JniSignatureAttribute("[B", "protected final")]
	public JavaArray<byte> block_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Authenticator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([B)V", "private")]
	public Authenticator(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)Lsun/security/ssl/Authenticator;", "static")]
	public static Dova.JDK.java.lang.Object valueOf(Dova.JDK.sun.security.ssl.ProtocolVersion arg0, Dova.JDK.sun.security.ssl.CipherSuite.MacAlg arg1, Dova.JDK.javax.crypto.SecretKey arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)Lsun/security/ssl/Authenticator;", "static")]
	public static Dova.JDK.sun.security.ssl.Authenticator valueOf(Dova.JDK.sun.security.ssl.ProtocolVersion arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ssl/Authenticator;", "static")]
	public static Dova.JDK.sun.security.ssl.Authenticator nullTlsMac()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ssl/Authenticator;", "static")]
	public static Dova.JDK.sun.security.ssl.Authenticator nullDtlsMac()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator>(ret);
	}

	[JniSignatureAttribute("()Z", "abstract")]
	public bool seqNumOverflow()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "abstract")]
	public bool seqNumIsHuge()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "")]
	public void setEpochNumber(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "final")]
	public void increaseSequenceNumber()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(BI[B)[B", "")]
	public JavaArray<byte> acquireAuthenticationBytes(byte arg0, int arg1, JavaArray<byte> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)J", "static final")]
	public static long toLong(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[B", "final")]
	public JavaArray<byte> sequenceNumber()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$DTLS13Authenticator;", "private static final")]
	public partial class DTLS13Authenticator
		: Dova.JDK.sun.security.ssl.Authenticator.DTLSAuthenticator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DTLS13Authenticator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$DTLS13Authenticator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCK_SIZE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/ProtocolVersion;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireAuthenticationBytes", "(BI[B)[B"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int BLOCK_SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DTLS13Authenticator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)V", "private")]
		public DTLS13Authenticator(Dova.JDK.sun.security.ssl.ProtocolVersion arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$DTLS13Authenticator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BI[B)[B", "")]
		public JavaArray<byte> acquireAuthenticationBytes(byte arg0, int arg1, JavaArray<byte> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$DTLS10Authenticator;", "private static")]
	public partial class DTLS10Authenticator
		: Dova.JDK.sun.security.ssl.Authenticator.DTLSAuthenticator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DTLS10Authenticator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$DTLS10Authenticator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCK_SIZE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/ProtocolVersion;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireAuthenticationBytes", "(BI[B)[B"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int BLOCK_SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DTLS10Authenticator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)V", "private")]
		public DTLS10Authenticator(Dova.JDK.sun.security.ssl.ProtocolVersion arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$DTLS10Authenticator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BI[B)[B", "")]
		public JavaArray<byte> acquireAuthenticationBytes(byte arg0, int arg1, JavaArray<byte> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$TLS13Authenticator;", "private static final")]
	public partial class TLS13Authenticator
		: Dova.JDK.sun.security.ssl.Authenticator.SSLAuthenticator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TLS13Authenticator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$TLS13Authenticator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCK_SIZE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/ProtocolVersion;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireAuthenticationBytes", "(BI[B)[B"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int BLOCK_SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TLS13Authenticator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)V", "private")]
		public TLS13Authenticator(Dova.JDK.sun.security.ssl.ProtocolVersion arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$TLS13Authenticator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BI[B)[B", "")]
		public JavaArray<byte> acquireAuthenticationBytes(byte arg0, int arg1, JavaArray<byte> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$TLS10Authenticator;", "private static")]
	public partial class TLS10Authenticator
		: Dova.JDK.sun.security.ssl.Authenticator.SSLAuthenticator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TLS10Authenticator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$TLS10Authenticator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCK_SIZE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/ProtocolVersion;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireAuthenticationBytes", "(BI[B)[B"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int BLOCK_SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TLS10Authenticator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)V", "private")]
		public TLS10Authenticator(Dova.JDK.sun.security.ssl.ProtocolVersion arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$TLS10Authenticator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BI[B)[B", "")]
		public JavaArray<byte> acquireAuthenticationBytes(byte arg0, int arg1, JavaArray<byte> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$SSL30Authenticator;", "private static")]
	public partial class SSL30Authenticator
		: Dova.JDK.sun.security.ssl.Authenticator.SSLAuthenticator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSL30Authenticator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$SSL30Authenticator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCK_SIZE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireAuthenticationBytes", "(BI[B)[B"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int BLOCK_SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSL30Authenticator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSL30Authenticator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$SSL30Authenticator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BI[B)[B", "")]
		public JavaArray<byte> acquireAuthenticationBytes(byte arg0, int arg1, JavaArray<byte> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$DTLS10Mac;", "private static final")]
	public partial class DTLS10Mac
		: Dova.JDK.sun.security.ssl.Authenticator.DTLS10Authenticator
		, Dova.JDK.sun.security.ssl.Authenticator.MAC
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DTLS10Mac()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$DTLS10Mac;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "macImpl", "Lsun/security/ssl/Authenticator$MacImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "(BLjava/nio/ByteBuffer;[BZ)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "macAlg", "()Lsun/security/ssl/CipherSuite$MacAlg;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/Authenticator$MacImpl;", "private final")]
		public Dova.JDK.sun.security.ssl.Authenticator.MacImpl macImpl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator.MacImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DTLS10Mac(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)V", "public")]
		public DTLS10Mac(Dova.JDK.sun.security.ssl.ProtocolVersion arg0, Dova.JDK.sun.security.ssl.CipherSuite.MacAlg arg1, Dova.JDK.javax.crypto.SecretKey arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$DTLS10Mac;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[BZ)[B", "public")]
		public JavaArray<byte> compute(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/CipherSuite$MacAlg;", "public")]
		public Dova.JDK.sun.security.ssl.CipherSuite.MacAlg macAlg()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$TLS10Mac;", "private static final")]
	public partial class TLS10Mac
		: Dova.JDK.sun.security.ssl.Authenticator.TLS10Authenticator
		, Dova.JDK.sun.security.ssl.Authenticator.MAC
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TLS10Mac()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$TLS10Mac;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "macImpl", "Lsun/security/ssl/Authenticator$MacImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "(BLjava/nio/ByteBuffer;[BZ)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "macAlg", "()Lsun/security/ssl/CipherSuite$MacAlg;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/Authenticator$MacImpl;", "private final")]
		public Dova.JDK.sun.security.ssl.Authenticator.MacImpl macImpl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator.MacImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TLS10Mac(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)V", "public")]
		public TLS10Mac(Dova.JDK.sun.security.ssl.ProtocolVersion arg0, Dova.JDK.sun.security.ssl.CipherSuite.MacAlg arg1, Dova.JDK.javax.crypto.SecretKey arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$TLS10Mac;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[BZ)[B", "public")]
		public JavaArray<byte> compute(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/CipherSuite$MacAlg;", "public")]
		public Dova.JDK.sun.security.ssl.CipherSuite.MacAlg macAlg()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$SSL30Mac;", "private static final")]
	public partial class SSL30Mac
		: Dova.JDK.sun.security.ssl.Authenticator.SSL30Authenticator
		, Dova.JDK.sun.security.ssl.Authenticator.MAC
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSL30Mac()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$SSL30Mac;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "macImpl", "Lsun/security/ssl/Authenticator$MacImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "(BLjava/nio/ByteBuffer;[BZ)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "macAlg", "()Lsun/security/ssl/CipherSuite$MacAlg;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/Authenticator$MacImpl;", "private final")]
		public Dova.JDK.sun.security.ssl.Authenticator.MacImpl macImpl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator.MacImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSL30Mac(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)V", "public")]
		public SSL30Mac(Dova.JDK.sun.security.ssl.ProtocolVersion arg0, Dova.JDK.sun.security.ssl.CipherSuite.MacAlg arg1, Dova.JDK.javax.crypto.SecretKey arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$SSL30Mac;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[BZ)[B", "public")]
		public JavaArray<byte> compute(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/CipherSuite$MacAlg;", "public")]
		public Dova.JDK.sun.security.ssl.CipherSuite.MacAlg macAlg()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$SSLNullMac;", "private static final")]
	public partial class SSLNullMac
		: Dova.JDK.sun.security.ssl.Authenticator.SSLNullAuthenticator
		, Dova.JDK.sun.security.ssl.Authenticator.MAC
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLNullMac()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$SSLNullMac;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "macImpl", "Lsun/security/ssl/Authenticator$MacImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "(BLjava/nio/ByteBuffer;[BZ)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "macAlg", "()Lsun/security/ssl/CipherSuite$MacAlg;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/Authenticator$MacImpl;", "private final")]
		public Dova.JDK.sun.security.ssl.Authenticator.MacImpl macImpl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator.MacImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLNullMac(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SSLNullMac() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$SSLNullMac;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[BZ)[B", "public")]
		public JavaArray<byte> compute(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/CipherSuite$MacAlg;", "public")]
		public Dova.JDK.sun.security.ssl.CipherSuite.MacAlg macAlg()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$DTLSNullMac;", "private static final")]
	public partial class DTLSNullMac
		: Dova.JDK.sun.security.ssl.Authenticator.DTLSNullAuthenticator
		, Dova.JDK.sun.security.ssl.Authenticator.MAC
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DTLSNullMac()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$DTLSNullMac;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "macImpl", "Lsun/security/ssl/Authenticator$MacImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "(BLjava/nio/ByteBuffer;[BZ)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "macAlg", "()Lsun/security/ssl/CipherSuite$MacAlg;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/Authenticator$MacImpl;", "private final")]
		public Dova.JDK.sun.security.ssl.Authenticator.MacImpl macImpl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator.MacImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DTLSNullMac(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DTLSNullMac() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$DTLSNullMac;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[BZ)[B", "public")]
		public JavaArray<byte> compute(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/CipherSuite$MacAlg;", "public")]
		public Dova.JDK.sun.security.ssl.CipherSuite.MacAlg macAlg()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$MacImpl;", "private")]
	public partial class MacImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.Authenticator.MAC
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MacImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$MacImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "macAlg", "Lsun/security/ssl/CipherSuite$MacAlg;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mac", "Ljavax/crypto/Mac;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/security/ssl/Authenticator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "(BLjava/nio/ByteBuffer;[BZ)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "macAlg", "()Lsun/security/ssl/CipherSuite$MacAlg;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/CipherSuite$MacAlg;", "private final")]
		public Dova.JDK.sun.security.ssl.CipherSuite.MacAlg macAlg_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/crypto/Mac;", "private final")]
		public Dova.JDK.javax.crypto.Mac mac_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.Mac>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/Authenticator;", "final")]
		public Dova.JDK.sun.security.ssl.Authenticator this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.Authenticator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MacImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;)V", "private")]
		public MacImpl(Dova.JDK.sun.security.ssl.Authenticator arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/Authenticator;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite$MacAlg;Ljavax/crypto/SecretKey;)V", "private")]
		public MacImpl(Dova.JDK.sun.security.ssl.Authenticator arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.CipherSuite.MacAlg arg2, Dova.JDK.javax.crypto.SecretKey arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$MacImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[BZ)[B", "public")]
		public JavaArray<byte> compute(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/CipherSuite$MacAlg;", "public")]
		public Dova.JDK.sun.security.ssl.CipherSuite.MacAlg macAlg()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$MAC;", "abstract static interface")]
	public partial interface MAC
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MAC()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$MAC;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "(BLjava/nio/ByteBuffer;[BZ)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "(BLjava/nio/ByteBuffer;Z)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "macAlg", "()Lsun/security/ssl/CipherSuite$MacAlg;"));
		}

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;[BZ)[B", "public abstract")]
		JavaArray<byte> compute(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, JavaArray<byte> arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(BLjava/nio/ByteBuffer;Z)[B", "public")]
		JavaArray<byte> compute(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/CipherSuite$MacAlg;", "public abstract")]
		Dova.JDK.sun.security.ssl.CipherSuite.MacAlg macAlg()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite.MacAlg>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$DTLSNullAuthenticator;", "private static")]
	public partial class DTLSNullAuthenticator
		: Dova.JDK.sun.security.ssl.Authenticator.DTLSAuthenticator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DTLSNullAuthenticator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$DTLSNullAuthenticator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DTLSNullAuthenticator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DTLSNullAuthenticator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$DTLSNullAuthenticator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$DTLSAuthenticator;", "private static")]
	public partial class DTLSAuthenticator
		: Dova.JDK.sun.security.ssl.Authenticator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DTLSAuthenticator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$DTLSAuthenticator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "seqNumOverflow", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "seqNumIsHuge", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEpochNumber", "(I)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DTLSAuthenticator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([B)V", "private")]
		public DTLSAuthenticator(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$DTLSAuthenticator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "")]
		public bool seqNumOverflow()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool seqNumIsHuge()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "")]
		public void setEpochNumber(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$SSLNullAuthenticator;", "private static")]
	public partial class SSLNullAuthenticator
		: Dova.JDK.sun.security.ssl.Authenticator.SSLAuthenticator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLNullAuthenticator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$SSLNullAuthenticator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLNullAuthenticator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SSLNullAuthenticator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$SSLNullAuthenticator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/Authenticator$SSLAuthenticator;", "private static")]
	public partial class SSLAuthenticator
		: Dova.JDK.sun.security.ssl.Authenticator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SSLAuthenticator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/Authenticator$SSLAuthenticator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "seqNumOverflow", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "seqNumIsHuge", "()Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SSLAuthenticator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([B)V", "private")]
		public SSLAuthenticator(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/Authenticator$SSLAuthenticator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "")]
		public bool seqNumOverflow()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool seqNumIsHuge()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}
}
