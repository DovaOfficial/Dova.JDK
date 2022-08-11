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

namespace Dova.JDK.com.sun.jndi.ldap.ext;

[JniSignatureAttribute("Lcom/sun/jndi/ldap/ext/StartTlsResponseImpl;", "public final")]
public partial class StartTlsResponseImpl
	: Dova.JDK.javax.naming.ldap.StartTlsResponse
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StartTlsResponseImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/ldap/ext/StartTlsResponseImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DNSNAME_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hostname", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ldapConnection", "Lcom/sun/jndi/ldap/Connection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originalInputStream", "Ljava/io/InputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originalOutputStream", "Ljava/io/OutputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sslSocket", "Ljavax/net/ssl/SSLSocket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultFactory", "Ljavax/net/ssl/SSLSocketFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentFactory", "Ljavax/net/ssl/SSLSocketFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suites", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "verifier", "Ljavax/net/ssl/HostnameVerifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isClosed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConnection", "(Lcom/sun/jndi/ldap/Connection;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPeerPrincipal", "(Ljavax/net/ssl/SSLSession;)Ljava/security/Principal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabledCipherSuites", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultFactory", "()Ljavax/net/ssl/SSLSocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startHandshake", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/SSLSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "negotiate", "()Ljavax/net/ssl/SSLSession;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "negotiate", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/SSLSession;"));
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
	public static int DNSNAME_TYPE_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private transient")]
	public Dova.JDK.java.lang.String hostname_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/Connection;", "private transient")]
	public Dova.JDK.com.sun.jndi.ldap.Connection ldapConnection_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.Connection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/InputStream;", "private transient")]
	public Dova.JDK.java.io.InputStream originalInputStream_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/OutputStream;", "private transient")]
	public Dova.JDK.java.io.OutputStream originalOutputStream_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLSocket;", "private transient")]
	public Dova.JDK.javax.net.ssl.SSLSocket sslSocket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLSocketFactory;", "private transient")]
	public Dova.JDK.javax.net.ssl.SSLSocketFactory defaultFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLSocketFactory;", "private transient")]
	public Dova.JDK.javax.net.ssl.SSLSocketFactory currentFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private transient")]
	public JavaArray<Dova.JDK.java.lang.String> suites_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/HostnameVerifier;", "private transient")]
	public Dova.JDK.javax.net.ssl.HostnameVerifier verifier_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.HostnameVerifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool isClosed_Property
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

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StartTlsResponseImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public StartTlsResponseImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/ldap/ext/StartTlsResponseImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", "private")]
	public bool verify(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.net.ssl.SSLSession arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/Connection;Ljava/lang/String;)V", "public")]
	public void setConnection(Dova.JDK.com.sun.jndi.ldap.Connection arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSession;)Ljava/security/Principal;", "private static")]
	public static Dova.JDK.java.security.Principal getPeerPrincipal(Dova.JDK.javax.net.ssl.SSLSession arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Principal>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public")]
	public void setEnabledCipherSuites(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSocketFactory;", "private")]
	public Dova.JDK.javax.net.ssl.SSLSocketFactory getDefaultFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/SSLSocket;", "private")]
	public Dova.JDK.javax.net.ssl.SSLSocket startHandshake(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocket>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/HostnameVerifier;)V", "public")]
	public void setHostnameVerifier(Dova.JDK.javax.net.ssl.HostnameVerifier arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLSession;", "public")]
	public Dova.JDK.javax.net.ssl.SSLSession negotiate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSession>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/SSLSession;", "public")]
	public Dova.JDK.javax.net.ssl.SSLSession negotiate(Dova.JDK.javax.net.ssl.SSLSocketFactory arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSession>(ret);
	}
}
