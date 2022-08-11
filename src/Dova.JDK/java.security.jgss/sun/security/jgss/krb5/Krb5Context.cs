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

namespace Dova.JDK.sun.security.jgss.krb5;

[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5Context;", "")]
public partial class Krb5Context
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.jgss.spi.GSSContextSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Krb5Context()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/jgss/krb5/Krb5Context;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATE_NEW", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATE_IN_PROCESS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATE_DONE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATE_DELETED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SESSION_KEY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INITIATOR_SUBKEY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCEPTOR_SUBKEY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "credDelegState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mutualAuthState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "replayDetState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sequenceDetState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "confState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "integState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegPolicyState", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isConstrainedDelegationTried", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mySeqNumber", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerSeqNumber", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keySrc", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerTokenTracker", "Lsun/security/jgss/TokenTracker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipherHelper", "Lsun/security/jgss/krb5/CipherHelper;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mySeqNumberLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerSeqNumberLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Lsun/security/krb5/EncryptionKey;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "myName", "Lsun/security/jgss/krb5/Krb5NameElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerName", "Lsun/security/jgss/krb5/Krb5NameElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lifetime", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initiator", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "channelBinding", "Lorg/ietf/jgss/ChannelBinding;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "myCred", "Lsun/security/jgss/krb5/Krb5CredElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegatedCred", "Lsun/security/jgss/krb5/Krb5CredElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tgt", "Lsun/security/krb5/Credentials;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceCreds", "Lsun/security/krb5/Credentials;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "apReq", "Lsun/security/krb5/KrbApReq;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caller", "Lsun/security/jgss/GSSCaller;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tktFlags", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authTime", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authzData", "Lsun/security/krb5/internal/AuthorizationData;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/GSSCaller;[B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/GSSCaller;Lsun/security/jgss/krb5/Krb5CredElement;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/GSSCaller;Lsun/security/jgss/krb5/Krb5NameElement;Lsun/security/jgss/krb5/Krb5CredElement;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "([BIILjava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "([BII[BILorg/ietf/jgss/MessageProp;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "([BIILorg/ietf/jgss/MessageProp;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKey", "()Lsun/security/krb5/EncryptionKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "([BII[BILorg/ietf/jgss/MessageProp;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "([BIILorg/ietf/jgss/MessageProp;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "(Ljava/io/InputStream;[BILorg/ietf/jgss/MessageProp;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "export", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvider", "()Ljava/security/Provider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inquireSecContext", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChannelBinding", "()Lorg/ietf/jgss/ChannelBinding;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetPeerSequenceNumber", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetMySequenceNumber", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestCredDeleg", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestSequenceDet", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestMutualAuth", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setChannelBinding", "(Lorg/ietf/jgss/ChannelBinding;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestConf", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestInteg", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initSecContext", "(Ljava/io/InputStream;I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEstablished", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWrapSizeLimit", "(IZI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSequencingAndReplayProps", "(Lsun/security/jgss/krb5/MessageToken;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSequencingAndReplayProps", "(Lsun/security/jgss/krb5/MessageToken_v2;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTktFlags", "([Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCaller", "()Lsun/security/jgss/GSSCaller;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCipherHelper", "(Lsun/security/krb5/EncryptionKey;)Lsun/security/jgss/krb5/CipherHelper;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setReplayDetState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSequenceDetState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConfState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIntegState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDelegPolicyState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAuthzData", "(Lsun/security/krb5/internal/AuthorizationData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDelegCred", "(Lsun/security/jgss/krb5/Krb5CredElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "incrementMySequenceNumber", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeySrc", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCredDelegState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMutualAuthState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryConstrainedDelegation", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAuthTime", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHexBytes", "([BII)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptSecContext", "(Ljava/io/InputStream;I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSrcName", "()Lsun/security/jgss/spi/GSSNameSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargName", "()Lsun/security/jgss/spi/GSSNameSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setKey", "(ILsun/security/krb5/EncryptionKey;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "printState", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSequenceDetState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMIC", "([BIILjava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMIC", "([BIILorg/ietf/jgss/MessageProp;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMIC", "([BII[BILorg/ietf/jgss/MessageProp;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMIC", "(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyMIC", "([BII[BIILorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyMIC", "(Ljava/io/InputStream;Ljava/io/InputStream;Lorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyMIC", "(Ljava/io/InputStream;[BIILorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestReplayDet", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestAnonymity", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestLifetime", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCredDelegState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMutualAuthState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReplayDetState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnonymityState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTransferable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProtReady", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntegState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLifetime", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMech", "()Lorg/ietf/jgss/Oid;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDelegCred", "()Lsun/security/jgss/spi/GSSCredentialSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInitiator", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDelegPolicyState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestDelegPolicy", "(Z)V"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STATE_NEW_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int STATE_IN_PROCESS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STATE_DONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STATE_DELETED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SESSION_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int INITIATOR_SUBKEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ACCEPTOR_SUBKEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool credDelegState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool mutualAuthState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool replayDetState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool sequenceDetState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool confState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool integState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool delegPolicyState_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool isConstrainedDelegationTried_Property
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

	[JniSignatureAttribute("I", "private")]
	public int mySeqNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int peerSeqNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int keySrc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/TokenTracker;", "private")]
	public Dova.JDK.sun.security.jgss.TokenTracker peerTokenTracker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.TokenTracker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/krb5/CipherHelper;", "private")]
	public Dova.JDK.sun.security.jgss.krb5.CipherHelper cipherHelper_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.CipherHelper>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object mySeqNumberLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object peerSeqNumberLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/EncryptionKey;", "private")]
	public Dova.JDK.sun.security.krb5.EncryptionKey key_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5NameElement;", "private")]
	public Dova.JDK.sun.security.jgss.krb5.Krb5NameElement myName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.Krb5NameElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5NameElement;", "private")]
	public Dova.JDK.sun.security.jgss.krb5.Krb5NameElement peerName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.Krb5NameElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int lifetime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool initiator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("Lorg/ietf/jgss/ChannelBinding;", "private")]
	public Dova.JDK.org.ietf.jgss.ChannelBinding channelBinding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.ChannelBinding>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5CredElement;", "private")]
	public Dova.JDK.sun.security.jgss.krb5.Krb5CredElement myCred_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.Krb5CredElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5CredElement;", "private")]
	public Dova.JDK.sun.security.jgss.krb5.Krb5CredElement delegatedCred_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.Krb5CredElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/Credentials;", "private")]
	public Dova.JDK.sun.security.krb5.Credentials tgt_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/Credentials;", "private")]
	public Dova.JDK.sun.security.krb5.Credentials serviceCreds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/KrbApReq;", "private")]
	public Dova.JDK.sun.security.krb5.KrbApReq apReq_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.KrbApReq>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/jgss/GSSCaller;", "private final")]
	public Dova.JDK.sun.security.jgss.GSSCaller caller_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.GSSCaller>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("[Z", "private")]
	public JavaArray<bool> tktFlags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String authTime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/AuthorizationData;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.AuthorizationData authzData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.AuthorizationData>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Krb5Context(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;[B)V", "public")]
	public Krb5Context(Dova.JDK.sun.security.jgss.GSSCaller arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;Lsun/security/jgss/krb5/Krb5CredElement;)V", "")]
	public Krb5Context(Dova.JDK.sun.security.jgss.GSSCaller arg0, Dova.JDK.sun.security.jgss.krb5.Krb5CredElement arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/GSSCaller;Lsun/security/jgss/krb5/Krb5NameElement;Lsun/security/jgss/krb5/Krb5CredElement;I)V", "")]
	public Krb5Context(Dova.JDK.sun.security.jgss.GSSCaller arg0, Dova.JDK.sun.security.jgss.krb5.Krb5NameElement arg1, Dova.JDK.sun.security.jgss.krb5.Krb5CredElement arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/jgss/krb5/Krb5Context;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V", "public final")]
	public void wrap(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.org.ietf.jgss.MessageProp arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BIILjava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V", "public final")]
	public void wrap(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.java.io.OutputStream arg3, Dova.JDK.org.ietf.jgss.MessageProp arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("([BII[BILorg/ietf/jgss/MessageProp;)I", "public final")]
	public int wrap(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, Dova.JDK.org.ietf.jgss.MessageProp arg5)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([BIILorg/ietf/jgss/MessageProp;)[B", "public final")]
	public JavaArray<byte> wrap(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.org.ietf.jgss.MessageProp arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void checkPermission(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/EncryptionKey;", "private final")]
	public Dova.JDK.sun.security.krb5.EncryptionKey getKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
	}

	[JniSignatureAttribute("([BII[BILorg/ietf/jgss/MessageProp;)I", "public final")]
	public int unwrap(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, Dova.JDK.org.ietf.jgss.MessageProp arg5)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("([BIILorg/ietf/jgss/MessageProp;)[B", "public final")]
	public JavaArray<byte> unwrap(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.org.ietf.jgss.MessageProp arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;[BILorg/ietf/jgss/MessageProp;)I", "public final")]
	public int unwrap(Dova.JDK.java.io.InputStream arg0, JavaArray<byte> arg1, int arg2, Dova.JDK.org.ietf.jgss.MessageProp arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V", "public final")]
	public void unwrap(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.org.ietf.jgss.MessageProp arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()[B", "public final")]
	public JavaArray<byte> export()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/Provider;", "public final")]
	public Dova.JDK.java.security.Provider getProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object inquireSecContext(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lorg/ietf/jgss/ChannelBinding;", "final")]
	public Dova.JDK.org.ietf.jgss.ChannelBinding getChannelBinding()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.ChannelBinding>(ret);
	}

	[JniSignatureAttribute("(I)V", "final")]
	public void resetPeerSequenceNumber(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(I)V", "final")]
	public void resetMySequenceNumber(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public final")]
	public void requestCredDeleg(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public final")]
	public void requestSequenceDet(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public final")]
	public void requestMutualAuth(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/ChannelBinding;)V", "public final")]
	public void setChannelBinding(Dova.JDK.org.ietf.jgss.ChannelBinding arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public final")]
	public void requestConf(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public final")]
	public void requestInteg(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;I)[B", "public final")]
	public JavaArray<byte> initSecContext(Dova.JDK.java.io.InputStream arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isEstablished()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("(IZI)I", "public final")]
	public int getWrapSizeLimit(int arg0, bool arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/MessageToken;Lorg/ietf/jgss/MessageProp;)V", "private")]
	public void setSequencingAndReplayProps(Dova.JDK.sun.security.jgss.krb5.MessageToken arg0, Dova.JDK.org.ietf.jgss.MessageProp arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/MessageToken_v2;Lorg/ietf/jgss/MessageProp;)V", "private")]
	public void setSequencingAndReplayProps(Dova.JDK.sun.security.jgss.krb5.MessageToken_v2 arg0, Dova.JDK.org.ietf.jgss.MessageProp arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("([Z)V", "public")]
	public void setTktFlags(JavaArray<bool> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("()Lsun/security/jgss/GSSCaller;", "")]
	public Dova.JDK.sun.security.jgss.GSSCaller getCaller()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.GSSCaller>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/EncryptionKey;)Lsun/security/jgss/krb5/CipherHelper;", "final")]
	public Dova.JDK.sun.security.jgss.krb5.CipherHelper getCipherHelper(Dova.JDK.sun.security.krb5.EncryptionKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.krb5.CipherHelper>(ret);
	}

	[JniSignatureAttribute("(Z)V", "final")]
	public void setReplayDetState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Z)V", "final")]
	public void setSequenceDetState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Z)V", "final")]
	public void setConfState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Z)V", "final")]
	public void setIntegState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Z)V", "final")]
	public void setDelegPolicyState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/AuthorizationData;)V", "public")]
	public void setAuthzData(Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5CredElement;)V", "final")]
	public void setDelegCred(Dova.JDK.sun.security.jgss.krb5.Krb5CredElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("()I", "final")]
	public int incrementMySequenceNumber()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[38]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getKeySrc()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "final")]
	public void setCredDelegState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Z)V", "final")]
	public void setMutualAuthState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void tryConstrainedDelegation()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setAuthTime(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("([BII)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getHexBytes(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;I)[B", "public final")]
	public JavaArray<byte> acceptSecContext(Dova.JDK.java.io.InputStream arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/jgss/spi/GSSNameSpi;", "public final")]
	public Dova.JDK.sun.security.jgss.spi.GSSNameSpi getSrcName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSNameSpi>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/jgss/spi/GSSNameSpi;", "public final")]
	public Dova.JDK.sun.security.jgss.spi.GSSNameSpi getTargName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSNameSpi>(ret);
	}

	[JniSignatureAttribute("(ILsun/security/krb5/EncryptionKey;)V", "final")]
	public void setKey(int arg0, Dova.JDK.sun.security.krb5.EncryptionKey arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String printState(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool getSequenceDetState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[50]);
		return ret;
	}

	[JniSignatureAttribute("([BIILjava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V", "private")]
	public void getMIC(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.java.io.OutputStream arg3, Dova.JDK.org.ietf.jgss.MessageProp arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("([BIILorg/ietf/jgss/MessageProp;)[B", "public final")]
	public JavaArray<byte> getMIC(JavaArray<byte> arg0, int arg1, int arg2, Dova.JDK.org.ietf.jgss.MessageProp arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BII[BILorg/ietf/jgss/MessageProp;)I", "private")]
	public int getMIC(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, Dova.JDK.org.ietf.jgss.MessageProp arg5)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Lorg/ietf/jgss/MessageProp;)V", "public final")]
	public void getMIC(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.org.ietf.jgss.MessageProp arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BII[BIILorg/ietf/jgss/MessageProp;)V", "public final")]
	public void verifyMIC(JavaArray<byte> arg0, int arg1, int arg2, JavaArray<byte> arg3, int arg4, int arg5, Dova.JDK.org.ietf.jgss.MessageProp arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/InputStream;Lorg/ietf/jgss/MessageProp;)V", "public final")]
	public void verifyMIC(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.InputStream arg1, Dova.JDK.org.ietf.jgss.MessageProp arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;[BIILorg/ietf/jgss/MessageProp;)V", "private")]
	public void verifyMIC(Dova.JDK.java.io.InputStream arg0, JavaArray<byte> arg1, int arg2, int arg3, Dova.JDK.org.ietf.jgss.MessageProp arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Z)V", "public final")]
	public void requestReplayDet(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public final")]
	public void requestAnonymity(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void requestLifetime(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool getCredDelegState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[61]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool getMutualAuthState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[62]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool getReplayDetState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[63]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool getAnonymityState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[64]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isTransferable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[65]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isProtReady()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[66]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool getConfState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[67]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool getIntegState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[68]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getLifetime()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[69]);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/ietf/jgss/Oid;", "public final")]
	public Dova.JDK.org.ietf.jgss.Oid getMech()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.Oid>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/jgss/spi/GSSCredentialSpi;", "public final")]
	public Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi getDelegCred()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.jgss.spi.GSSCredentialSpi>(ret);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isInitiator()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[72]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool getDelegPolicyState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[73]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public final")]
	public void requestDelegPolicy(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("Lsun/security/jgss/krb5/Krb5Context$KerberosSessionKey;", "static")]
	public partial class KerberosSessionKey
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.security.Key
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KerberosSessionKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/jgss/krb5/Krb5Context$KerberosSessionKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Lsun/security/krb5/EncryptionKey;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/EncryptionKey;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEncoded", "()[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFormat", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlgorithm", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lsun/security/krb5/EncryptionKey;", "private final")]
		public Dova.JDK.sun.security.krb5.EncryptionKey key_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KerberosSessionKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/krb5/EncryptionKey;)V", "")]
		public KerberosSessionKey(Dova.JDK.sun.security.krb5.EncryptionKey arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/jgss/krb5/Krb5Context$KerberosSessionKey;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[B", "public")]
		public JavaArray<byte> getEncoded()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getFormat()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getAlgorithm()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
