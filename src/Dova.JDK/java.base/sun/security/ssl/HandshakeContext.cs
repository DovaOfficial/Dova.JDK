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

[JniSignatureAttribute("Lsun/security/ssl/HandshakeContext;", "abstract")]
public partial class HandshakeContext
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.ssl.ConnectionContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HandshakeContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/HandshakeContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allowUnsafeRenegotiation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allowLegacyHelloMessages", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeConsumers", "Ljava/util/LinkedHashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeProducers", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslContext", "Lsun/security/ssl/SSLContextImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "conContext", "Lsun/security/ssl/TransportContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslConfig", "Lsun/security/ssl/SSLConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeProtocols", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeCipherSuites", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algorithmConstraints", "Ljava/security/AlgorithmConstraints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maximumActiveProtocol", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeOutput", "Lsun/security/ssl/HandshakeOutStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeHash", "Lsun/security/ssl/HandshakeHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeSession", "Lsun/security/ssl/SSLSessionImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeFinished", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kickstartMessageDelivered", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isResumption", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resumingSession", "Lsun/security/ssl/SSLSessionImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "statelessResumption", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegatedActions", "Ljava/util/Queue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "taskDelegated", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegatedThrown", "Ljava/lang/Exception;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "negotiatedProtocol", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "negotiatedCipherSuite", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakePossessions", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeCredentials", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeKeyDerivation", "Lsun/security/ssl/SSLKeyDerivation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeKeyExchange", "Lsun/security/ssl/SSLKeyExchange;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseReadSecret", "Ljavax/crypto/SecretKey;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseWriteSecret", "Ljavax/crypto/SecretKey;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientHelloVersion", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "applicationProtocol", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientHelloRandom", "Lsun/security/ssl/RandomCookie;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverHelloRandom", "Lsun/security/ssl/RandomCookie;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "certRequestContext", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeExtensions", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxFragmentLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localSupportedSignAlgs", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerRequestedSignatureSchemes", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerRequestedCertSignSchemes", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerSupportedAuthorities", "[Ljavax/security/auth/x500/X500Principal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientRequestedNamedGroups", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverSelectedNamedGroup", "Lsun/security/ssl/NamedGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestedServerNames", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "negotiatedServerName", "Ljavax/net/ssl/SNIServerName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "staplingActive", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/TransportContext;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/TransportContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatch", "(BLjava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatch", "(BLsun/security/ssl/Plaintext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHandshakeType", "(Lsun/security/ssl/TransportContext;Lsun/security/ssl/Plaintext;)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kickstart", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNegotiable", "(Lsun/security/ssl/ProtocolVersion;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNegotiable", "(Lsun/security/ssl/CipherSuite;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isNegotiable", "(Ljava/util/List;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isNegotiable", "(Ljava/util/List;Lsun/security/ssl/CipherSuite;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getActiveProtocols", "(Ljava/util/List;Ljava/util/List;Ljava/security/AlgorithmConstraints;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getActiveCipherSuites", "(Ljava/util/List;Ljava/util/List;Ljava/security/AlgorithmConstraints;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isActivatable", "(Lsun/security/ssl/CipherSuite;Ljava/security/AlgorithmConstraints;Ljava/util/Map;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRequestedServerNames", "()Ljava/util/List;"));
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool allowUnsafeRenegotiation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool allowLegacyHelloMessages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "")]
	public Dova.JDK.java.util.LinkedHashMap handshakeConsumers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "final")]
	public Dova.JDK.java.util.HashMap handshakeProducers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLContextImpl;", "final")]
	public Dova.JDK.sun.security.ssl.SSLContextImpl sslContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLContextImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/TransportContext;", "final")]
	public Dova.JDK.sun.security.ssl.TransportContext conContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.TransportContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLConfiguration;", "final")]
	public Dova.JDK.sun.security.ssl.SSLConfiguration sslConfig_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List activeProtocols_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List activeCipherSuites_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AlgorithmConstraints;", "final")]
	public Dova.JDK.java.security.AlgorithmConstraints algorithmConstraints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "final")]
	public Dova.JDK.sun.security.ssl.ProtocolVersion maximumActiveProtocol_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeOutStream;", "final")]
	public Dova.JDK.sun.security.ssl.HandshakeOutStream handshakeOutput_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeOutStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeHash;", "final")]
	public Dova.JDK.sun.security.ssl.HandshakeHash handshakeHash_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLSessionImpl;", "")]
	public Dova.JDK.sun.security.ssl.SSLSessionImpl handshakeSession_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSessionImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool handshakeFinished_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool kickstartMessageDelivered_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool isResumption_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLSessionImpl;", "")]
	public Dova.JDK.sun.security.ssl.SSLSessionImpl resumingSession_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSessionImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool statelessResumption_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Queue;", "final")]
	public Dova.JDK.java.util.Queue delegatedActions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Queue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "volatile")]
	public bool taskDelegated_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Exception;", "volatile")]
	public Dova.JDK.java.lang.Exception delegatedThrown_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Exception>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "")]
	public Dova.JDK.sun.security.ssl.ProtocolVersion negotiatedProtocol_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "")]
	public Dova.JDK.sun.security.ssl.CipherSuite negotiatedCipherSuite_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List handshakePossessions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List handshakeCredentials_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyDerivation;", "")]
	public Dova.JDK.sun.security.ssl.SSLKeyDerivation handshakeKeyDerivation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyDerivation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLKeyExchange;", "")]
	public Dova.JDK.sun.security.ssl.SSLKeyExchange handshakeKeyExchange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLKeyExchange>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "")]
	public Dova.JDK.javax.crypto.SecretKey baseReadSecret_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/crypto/SecretKey;", "")]
	public Dova.JDK.javax.crypto.SecretKey baseWriteSecret_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int clientHelloVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String applicationProtocol_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/RandomCookie;", "")]
	public Dova.JDK.sun.security.ssl.RandomCookie clientHelloRandom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.RandomCookie>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/RandomCookie;", "")]
	public Dova.JDK.sun.security.ssl.RandomCookie serverHelloRandom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.RandomCookie>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> certRequestContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "final")]
	public Dova.JDK.java.util.Map handshakeExtensions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int maxFragmentLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List localSupportedSignAlgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List peerRequestedSignatureSchemes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List peerRequestedCertSignSchemes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/security/auth/x500/X500Principal;", "")]
	public JavaArray<Dova.JDK.javax.security.auth.x500.X500Principal> peerSupportedAuthorities_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.security.auth.x500.X500Principal>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List clientRequestedNamedGroups_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/NamedGroup;", "")]
	public Dova.JDK.sun.security.ssl.NamedGroup serverSelectedNamedGroup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.NamedGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List requestedServerNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SNIServerName;", "")]
	public Dova.JDK.javax.net.ssl.SNIServerName negotiatedServerName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SNIServerName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool staplingActive_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HandshakeContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/TransportContext;)V", "protected")]
	public HandshakeContext(Dova.JDK.sun.security.ssl.SSLContextImpl arg0, Dova.JDK.sun.security.ssl.TransportContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/TransportContext;)V", "protected")]
	public HandshakeContext(Dova.JDK.sun.security.ssl.TransportContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/HandshakeContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(BLjava/nio/ByteBuffer;)V", "")]
	public void dispatch(byte arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(BLsun/security/ssl/Plaintext;)V", "")]
	public void dispatch(byte arg0, Dova.JDK.sun.security.ssl.Plaintext arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initialize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/TransportContext;Lsun/security/ssl/Plaintext;)B", "static")]
	public static byte getHandshakeType(Dova.JDK.sun.security.ssl.TransportContext arg0, Dova.JDK.sun.security.ssl.Plaintext arg1)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "abstract")]
	public void kickstart()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ProtocolVersion;)Z", "")]
	public bool isNegotiable(Dova.JDK.sun.security.ssl.ProtocolVersion arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/ssl/CipherSuite;)Z", "")]
	public bool isNegotiable(Dova.JDK.sun.security.ssl.CipherSuite arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;Lsun/security/ssl/ProtocolVersion;Lsun/security/ssl/CipherSuite;)Z", "static final")]
	public static bool isNegotiable(Dova.JDK.java.util.List arg0, Dova.JDK.sun.security.ssl.ProtocolVersion arg1, Dova.JDK.sun.security.ssl.CipherSuite arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;Lsun/security/ssl/CipherSuite;)Z", "static final")]
	public static bool isNegotiable(Dova.JDK.java.util.List arg0, Dova.JDK.sun.security.ssl.CipherSuite arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/security/AlgorithmConstraints;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getActiveProtocols(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.security.AlgorithmConstraints arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/security/AlgorithmConstraints;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getActiveCipherSuites(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.security.AlgorithmConstraints arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/CipherSuite;Ljava/security/AlgorithmConstraints;Ljava/util/Map;)Z", "private static")]
	public static bool isActivatable(Dova.JDK.sun.security.ssl.CipherSuite arg0, Dova.JDK.java.security.AlgorithmConstraints arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "")]
	public Dova.JDK.java.util.List getRequestedServerNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}
}
