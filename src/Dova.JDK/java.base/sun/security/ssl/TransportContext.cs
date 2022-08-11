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

[JniSignatureAttribute("Lsun/security/ssl/TransportContext;", "final")]
public partial class TransportContext
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.security.ssl.ConnectionContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TransportContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/TransportContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transport", "Lsun/security/ssl/SSLTransport;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "consumers", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acc", "Ljava/security/AccessControlContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslContext", "Lsun/security/ssl/SSLContextImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslConfig", "Lsun/security/ssl/SSLConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputRecord", "Lsun/security/ssl/InputRecord;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputRecord", "Lsun/security/ssl/OutputRecord;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isUnsureMode", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isNegotiated", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isBroken", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isInputCloseNotified", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerUserCanceled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closeReason", "Ljava/lang/Exception;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegatedThrown", "Ljava/lang/Exception;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "needHandshakeFinishedStatus", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasDelegatedFinished", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "conSession", "Lsun/security/ssl/SSLSessionImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protocolVersion", "Lsun/security/ssl/ProtocolVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "applicationProtocol", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeContext", "Lsun/security/ssl/HandshakeContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "secureRenegotiation", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientVerifyData", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverVerifyData", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverRequestedNamedGroups", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cipherSuite", "Lsun/security/ssl/CipherSuite;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "emptyByteArray", "[B"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/SSLTransport;Lsun/security/ssl/SSLConfiguration;Lsun/security/ssl/InputRecord;Lsun/security/ssl/OutputRecord;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/SSLTransport;Lsun/security/ssl/SSLConfiguration;Lsun/security/ssl/InputRecord;Lsun/security/ssl/OutputRecord;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/SSLTransport;Lsun/security/ssl/InputRecord;Lsun/security/ssl/OutputRecord;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/SSLTransport;Lsun/security/ssl/InputRecord;Lsun/security/ssl/OutputRecord;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatch", "(Lsun/security/ssl/Plaintext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warning", "(Lsun/security/ssl/Alert;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUseClientMode", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fatal", "(Lsun/security/ssl/Alert;Ljava/lang/Throwable;)Ljavax/net/ssl/SSLException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fatal", "(Lsun/security/ssl/Alert;Ljava/lang/String;)Ljavax/net/ssl/SSLException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fatal", "(Lsun/security/ssl/Alert;Ljava/lang/String;Ljava/lang/Throwable;)Ljavax/net/ssl/SSLException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fatal", "(Lsun/security/ssl/Alert;Ljava/lang/String;ZLjava/lang/Throwable;)Ljavax/net/ssl/SSLException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeInbound", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeOutbound", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOutboundDone", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kickstart", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeNotify", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOutboundClosed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInboundClosed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initiateInboundClose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "passiveInboundClose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initiateOutboundClose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishHandshake", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPostHandshakeContext", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishPostHandshake", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLTransport;", "final")]
	public Dova.JDK.sun.security.ssl.SSLTransport transport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLTransport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "final")]
	public Dova.JDK.java.util.Map consumers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "final")]
	public Dova.JDK.java.security.AccessControlContext acc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLContextImpl;", "final")]
	public Dova.JDK.sun.security.ssl.SSLContextImpl sslContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLContextImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLConfiguration;", "final")]
	public Dova.JDK.sun.security.ssl.SSLConfiguration sslConfig_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/InputRecord;", "final")]
	public Dova.JDK.sun.security.ssl.InputRecord inputRecord_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.InputRecord>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/OutputRecord;", "final")]
	public Dova.JDK.sun.security.ssl.OutputRecord outputRecord_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.OutputRecord>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool isUnsureMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool isNegotiated_Property
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

	[JniSignatureAttribute("Z", "")]
	public bool isBroken_Property
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

	[JniSignatureAttribute("Z", "")]
	public bool isInputCloseNotified_Property
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

	[JniSignatureAttribute("Z", "")]
	public bool peerUserCanceled_Property
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

	[JniSignatureAttribute("Ljava/lang/Exception;", "")]
	public Dova.JDK.java.lang.Exception closeReason_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Exception>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Exception;", "")]
	public Dova.JDK.java.lang.Exception delegatedThrown_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Exception>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool needHandshakeFinishedStatus_Property
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
	public bool hasDelegatedFinished_Property
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

	[JniSignatureAttribute("Lsun/security/ssl/SSLSessionImpl;", "")]
	public Dova.JDK.sun.security.ssl.SSLSessionImpl conSession_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLSessionImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/ProtocolVersion;", "")]
	public Dova.JDK.sun.security.ssl.ProtocolVersion protocolVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.ProtocolVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String applicationProtocol_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeContext;", "")]
	public Dova.JDK.sun.security.ssl.HandshakeContext handshakeContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool secureRenegotiation_Property
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

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> clientVerifyData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> serverVerifyData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List serverRequestedNamedGroups_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/CipherSuite;", "")]
	public Dova.JDK.sun.security.ssl.CipherSuite cipherSuite_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CipherSuite>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> emptyByteArray_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TransportContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/SSLTransport;Lsun/security/ssl/SSLConfiguration;Lsun/security/ssl/InputRecord;Lsun/security/ssl/OutputRecord;Z)V", "private")]
	public TransportContext(Dova.JDK.sun.security.ssl.SSLContextImpl arg0, Dova.JDK.sun.security.ssl.SSLTransport arg1, Dova.JDK.sun.security.ssl.SSLConfiguration arg2, Dova.JDK.sun.security.ssl.InputRecord arg3, Dova.JDK.sun.security.ssl.OutputRecord arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/SSLTransport;Lsun/security/ssl/SSLConfiguration;Lsun/security/ssl/InputRecord;Lsun/security/ssl/OutputRecord;)V", "")]
	public TransportContext(Dova.JDK.sun.security.ssl.SSLContextImpl arg0, Dova.JDK.sun.security.ssl.SSLTransport arg1, Dova.JDK.sun.security.ssl.SSLConfiguration arg2, Dova.JDK.sun.security.ssl.InputRecord arg3, Dova.JDK.sun.security.ssl.OutputRecord arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/SSLTransport;Lsun/security/ssl/InputRecord;Lsun/security/ssl/OutputRecord;Z)V", "")]
	public TransportContext(Dova.JDK.sun.security.ssl.SSLContextImpl arg0, Dova.JDK.sun.security.ssl.SSLTransport arg1, Dova.JDK.sun.security.ssl.InputRecord arg2, Dova.JDK.sun.security.ssl.OutputRecord arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Lsun/security/ssl/SSLContextImpl;Lsun/security/ssl/SSLTransport;Lsun/security/ssl/InputRecord;Lsun/security/ssl/OutputRecord;)V", "")]
	public TransportContext(Dova.JDK.sun.security.ssl.SSLContextImpl arg0, Dova.JDK.sun.security.ssl.SSLTransport arg1, Dova.JDK.sun.security.ssl.InputRecord arg2, Dova.JDK.sun.security.ssl.OutputRecord arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/TransportContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/ssl/Plaintext;)V", "")]
	public void dispatch(Dova.JDK.sun.security.ssl.Plaintext arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Alert;)V", "")]
	public void warning(Dova.JDK.sun.security.ssl.Alert arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Z)V", "")]
	public void setUseClientMode(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Alert;Ljava/lang/Throwable;)Ljavax/net/ssl/SSLException;", "")]
	public Dova.JDK.javax.net.ssl.SSLException fatal(Dova.JDK.sun.security.ssl.Alert arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLException>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Alert;Ljava/lang/String;)Ljavax/net/ssl/SSLException;", "")]
	public Dova.JDK.javax.net.ssl.SSLException fatal(Dova.JDK.sun.security.ssl.Alert arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLException>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Alert;Ljava/lang/String;Ljava/lang/Throwable;)Ljavax/net/ssl/SSLException;", "")]
	public Dova.JDK.javax.net.ssl.SSLException fatal(Dova.JDK.sun.security.ssl.Alert arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Throwable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLException>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/Alert;Ljava/lang/String;ZLjava/lang/Throwable;)Ljavax/net/ssl/SSLException;", "")]
	public Dova.JDK.javax.net.ssl.SSLException fatal(Dova.JDK.sun.security.ssl.Alert arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.lang.Throwable arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLException>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void closeInbound()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()V", "")]
	public void closeOutbound()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isOutboundDone()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "")]
	public Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void kickstart()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Z)V", "")]
	public void closeNotify(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isOutboundClosed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isInboundClosed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void initiateInboundClose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void passiveInboundClose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initiateOutboundClose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "")]
	public Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus finishHandshake()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isPostHandshakeContext()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "")]
	public Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus finishPostHandshake()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/TransportContext$NotifyHandshake;", "private static")]
	public partial class NotifyHandshake
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NotifyHandshake()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/TransportContext$NotifyHandshake;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targets", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "event", "Ljavax/net/ssl/HandshakeCompletedEvent;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;Ljavax/net/ssl/HandshakeCompletedEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private final")]
		public Dova.JDK.java.util.Set targets_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/net/ssl/HandshakeCompletedEvent;", "private final")]
		public Dova.JDK.javax.net.ssl.HandshakeCompletedEvent @event_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.HandshakeCompletedEvent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NotifyHandshake(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljavax/net/ssl/HandshakeCompletedEvent;)V", "")]
		public NotifyHandshake(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.net.ssl.HandshakeCompletedEvent arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/TransportContext$NotifyHandshake;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
