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

namespace Dova.JDK.com.sun.jndi.ldap;

[JniSignatureAttribute("Lcom/sun/jndi/ldap/Connection;", "public final")]
public partial class Connection
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Runnable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Connection()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/ldap/Connection;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dump", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "worker", "Ljava/lang/Thread;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "v3", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "host", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "port", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "traceFile", "Ljava/io/OutputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "traceTagIn", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "traceTagOut", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inStream", "Ljava/io/InputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outStream", "Ljava/io/OutputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sock", "Ljava/net/Socket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Lcom/sun/jndi/ldap/LdapClient;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outMsgId", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pendingRequests", "Lcom/sun/jndi/ldap/LdapRequest;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closureReason", "Ljava/io/IOException;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "useable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readTimeout", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectTimeout", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isUpgradedToStartTls", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startTlsLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_HOSTNAME_VERIFICATION_DISABLED", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pauseLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paused", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tlsHandshakeListener", "Lcom/sun/jndi/ldap/Connection$HandshakeListener;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/ldap/LdapClient;Ljava/lang/String;ILjava/lang/String;IILjava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputStream", "()Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanup", "([Ljavax/naming/ldap/Control;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readFully", "(Ljava/io/InputStream;I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hostnameVerificationDisabledValue", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSocket", "(Ljava/lang/String;ILjava/lang/String;I)Ljava/net/Socket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createInetSocketAddress", "(Ljava/lang/String;I)Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHandshakeCompletedListener", "(Ljavax/net/ssl/SSLSocket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeRequest", "(Lcom/sun/jndi/ldap/BerEncoder;I)Lcom/sun/jndi/ldap/LdapRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeRequest", "(Lcom/sun/jndi/ldap/BerEncoder;IZ)Lcom/sun/jndi/ldap/LdapRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeRequest", "(Lcom/sun/jndi/ldap/BerEncoder;IZI)Lcom/sun/jndi/ldap/LdapRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRequest", "(Lcom/sun/jndi/ldap/LdapRequest;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unpauseReader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abandonRequest", "(Lcom/sun/jndi/ldap/LdapRequest;[Ljavax/naming/ldap/Control;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeRequest", "(Lcom/sun/jndi/ldap/LdapRequest;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMsgId", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abandonOutstandingReqs", "([Ljavax/naming/ldap/Control;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ldapUnbind", "([Ljavax/naming/ldap/Control;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTlsConnection", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceStreams", "(Ljava/io/InputStream;Ljava/io/OutputStream;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceStreams", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUpgradedToStartTls", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findRequest", "(I)Lcom/sun/jndi/ldap/LdapRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pauseReader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setV3", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBound", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readReply", "(Lcom/sun/jndi/ldap/LdapRequest;)Lcom/sun/jndi/ldap/BerDecoder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTlsServerCertificate", "()Ljava/security/cert/X509Certificate;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool debug_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int dump_Property
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

	[JniSignatureAttribute("Ljava/lang/Thread;", "private final")]
	public Dova.JDK.java.lang.Thread worker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool v3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String host_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public final")]
	public int port_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool bound_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/io/OutputStream;", "private")]
	public Dova.JDK.java.io.OutputStream traceFile_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String traceTagIn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String traceTagOut_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream inStream_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/OutputStream;", "public")]
	public Dova.JDK.java.io.OutputStream outStream_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/Socket;", "public")]
	public Dova.JDK.java.net.Socket sock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/LdapClient;", "private final")]
	public Dova.JDK.com.sun.jndi.ldap.LdapClient parent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.LdapClient>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int outMsgId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/LdapRequest;", "private")]
	public Dova.JDK.com.sun.jndi.ldap.LdapRequest pendingRequests_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.LdapRequest>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/IOException;", "volatile")]
	public Dova.JDK.java.io.IOException closureReason_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "volatile")]
	public bool useable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int readTimeout_Property
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

	[JniSignatureAttribute("I", "")]
	public int connectTimeout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool isUpgradedToStartTls_Property
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

	[JniSignatureAttribute("Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object startTlsLock_Property
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

	[JniSignatureAttribute("Z", "private static final")]
	public static bool IS_HOSTNAME_VERIFICATION_DISABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object pauseLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool paused_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/Connection$HandshakeListener;", "private volatile")]
	public Dova.JDK.com.sun.jndi.ldap.Connection.HandshakeListener tlsHandshakeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.Connection.HandshakeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Connection(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/LdapClient;Ljava/lang/String;ILjava/lang/String;IILjava/io/OutputStream;)V", "")]
	public Connection(Dova.JDK.com.sun.jndi.ldap.LdapClient arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, Dova.JDK.java.io.OutputStream arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/ldap/Connection;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void run()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "private synchronized")]
	public Dova.JDK.java.io.InputStream getInputStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("([Ljavax/naming/ldap/Control;Z)V", "")]
	public void cleanup(JavaArray<Dova.JDK.javax.naming.ldap.Control> arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;I)[B", "private static")]
	public static JavaArray<byte> readFully(Dova.JDK.java.io.InputStream arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool hostnameVerificationDisabledValue()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;I)Ljava/net/Socket;", "private")]
	public Dova.JDK.java.net.Socket createSocket(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/net/InetSocketAddress;", "private")]
	public Dova.JDK.java.net.InetSocketAddress createInetSocketAddress(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocket;)V", "public synchronized")]
	public void setHandshakeCompletedListener(Dova.JDK.javax.net.ssl.SSLSocket arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/BerEncoder;I)Lcom/sun/jndi/ldap/LdapRequest;", "")]
	public Dova.JDK.com.sun.jndi.ldap.LdapRequest writeRequest(Dova.JDK.com.sun.jndi.ldap.BerEncoder arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.LdapRequest>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/BerEncoder;IZ)Lcom/sun/jndi/ldap/LdapRequest;", "")]
	public Dova.JDK.com.sun.jndi.ldap.LdapRequest writeRequest(Dova.JDK.com.sun.jndi.ldap.BerEncoder arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.LdapRequest>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/BerEncoder;IZI)Lcom/sun/jndi/ldap/LdapRequest;", "")]
	public Dova.JDK.com.sun.jndi.ldap.LdapRequest writeRequest(Dova.JDK.com.sun.jndi.ldap.BerEncoder arg0, int arg1, bool arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.LdapRequest>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/LdapRequest;)V", "private synchronized")]
	public void addRequest(Dova.JDK.com.sun.jndi.ldap.LdapRequest arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void unpauseReader()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/LdapRequest;[Ljavax/naming/ldap/Control;)V", "")]
	public void abandonRequest(Dova.JDK.com.sun.jndi.ldap.LdapRequest arg0, JavaArray<Dova.JDK.javax.naming.ldap.Control> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/LdapRequest;)V", "synchronized")]
	public void removeRequest(Dova.JDK.com.sun.jndi.ldap.LdapRequest arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()I", "synchronized")]
	public int getMsgId()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("([Ljavax/naming/ldap/Control;)V", "synchronized")]
	public void abandonOutstandingReqs(JavaArray<Dova.JDK.javax.naming.ldap.Control> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("([Ljavax/naming/ldap/Control;)V", "private")]
	public void ldapUnbind(JavaArray<Dova.JDK.javax.naming.ldap.Control> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTlsConnection()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Z)V", "public synchronized")]
	public void replaceStreams(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "public synchronized")]
	public void replaceStreams(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isUpgradedToStartTls()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/jndi/ldap/LdapRequest;", "synchronized")]
	public Dova.JDK.com.sun.jndi.ldap.LdapRequest findRequest(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.LdapRequest>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void pauseReader()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(Z)V", "")]
	public void setV3(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void setBound()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/LdapRequest;)Lcom/sun/jndi/ldap/BerDecoder;", "")]
	public Dova.JDK.com.sun.jndi.ldap.BerDecoder readReply(Dova.JDK.com.sun.jndi.ldap.LdapRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.BerDecoder>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/cert/X509Certificate;", "public")]
	public Dova.JDK.java.security.cert.X509Certificate getTlsServerCertificate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/Connection$HandshakeListener;", "private")]
	public partial class HandshakeListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.net.ssl.HandshakeCompletedListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HandshakeListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/ldap/Connection$HandshakeListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tlsHandshakeCompleted", "Ljava/util/concurrent/CompletableFuture;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/jndi/ldap/Connection;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/ldap/Connection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handshakeCompleted", "(Ljavax/net/ssl/HandshakeCompletedEvent;)V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/CompletableFuture;", "private final")]
		public Dova.JDK.java.util.concurrent.CompletableFuture tlsHandshakeCompleted_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletableFuture>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jndi/ldap/Connection;", "final")]
		public Dova.JDK.com.sun.jndi.ldap.Connection this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.Connection>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HandshakeListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jndi/ldap/Connection;)V", "private")]
		public HandshakeListener(Dova.JDK.com.sun.jndi.ldap.Connection arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jndi/ldap/Connection$HandshakeListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/net/ssl/HandshakeCompletedEvent;)V", "public")]
		public void handshakeCompleted(Dova.JDK.javax.net.ssl.HandshakeCompletedEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}
