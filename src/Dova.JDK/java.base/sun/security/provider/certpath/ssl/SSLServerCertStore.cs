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

namespace Dova.JDK.sun.security.provider.certpath.ssl;

[JniSignatureAttribute("Lsun/security/provider/certpath/ssl/SSLServerCertStore;", "public final")]
public partial class SSLServerCertStore
	: Dova.JDK.java.security.cert.CertStoreSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLServerCertStore()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/ssl/SSLServerCertStore;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uri", "Ljava/net/URI;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "trustManager", "Lsun/security/provider/certpath/ssl/SSLServerCertStore$GetChainTrustManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "socketFactory", "Ljavax/net/ssl/SSLSocketFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "hostnameVerifier", "Ljavax/net/ssl/HostnameVerifier;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URI;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/net/URI;)Ljava/security/cert/CertStore;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMatchingCerts", "(Ljava/util/List;Ljava/security/cert/CertSelector;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;"));
	}

	[JniSignatureAttribute("Ljava/net/URI;", "private final")]
	public Dova.JDK.java.net.URI uri_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/ssl/SSLServerCertStore$GetChainTrustManager;", "private static final")]
	public static Dova.JDK.sun.security.provider.certpath.ssl.SSLServerCertStore.GetChainTrustManager trustManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.ssl.SSLServerCertStore.GetChainTrustManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLSocketFactory;", "private static final")]
	public static Dova.JDK.javax.net.ssl.SSLSocketFactory socketFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLSocketFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/HostnameVerifier;", "private static final")]
	public static Dova.JDK.javax.net.ssl.HostnameVerifier hostnameVerifier_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.HostnameVerifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLServerCertStore(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/net/URI;)V", "")]
	public SSLServerCertStore(Dova.JDK.java.net.URI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/ssl/SSLServerCertStore;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/net/URI;)Ljava/security/cert/CertStore;", "public static")]
	public static Dova.JDK.java.security.cert.CertStore getInstance(Dova.JDK.java.net.URI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.CertStore>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/security/cert/CertSelector;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getMatchingCerts(Dova.JDK.java.util.List arg0, Dova.JDK.java.security.cert.CertSelector arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection engineGetCertificates(Dova.JDK.java.security.cert.CertSelector arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection engineGetCRLs(Dova.JDK.java.security.cert.CRLSelector arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/ssl/SSLServerCertStore$GetChainTrustManager;", "private static")]
	public partial class GetChainTrustManager
		: Dova.JDK.javax.net.ssl.X509ExtendedTrustManager
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GetChainTrustManager()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/ssl/SSLServerCertStore$GetChainTrustManager;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverChain", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exchangedServerCerts", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanup", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List serverChain_Property
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

		[JniSignatureAttribute("Z", "private")]
		public bool exchangedServerCerts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GetChainTrustManager(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public GetChainTrustManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/ssl/SSLServerCertStore$GetChainTrustManager;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "")]
		public void cleanup()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()[Ljava/security/cert/X509Certificate;", "public")]
		public JavaArray<Dova.JDK.java.security.cert.X509Certificate> getAcceptedIssuers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
		}

		[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V", "public")]
		public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V", "public")]
		public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "public")]
		public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V", "public")]
		public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V", "public")]
		public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "public")]
		public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/security/provider/certpath/ssl/SSLServerCertStore$CS;", "private static")]
	public partial class CS
		: Dova.JDK.java.security.cert.CertStore
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CS()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/certpath/ssl/SSLServerCertStore$CS;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/cert/CertStoreSpi;Ljava/security/Provider;Ljava/lang/String;Ljava/security/cert/CertStoreParameters;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CS(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/cert/CertStoreSpi;Ljava/security/Provider;Ljava/lang/String;Ljava/security/cert/CertStoreParameters;)V", "protected")]
		public CS(Dova.JDK.java.security.cert.CertStoreSpi arg0, Dova.JDK.java.security.Provider arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.security.cert.CertStoreParameters arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/provider/certpath/ssl/SSLServerCertStore$CS;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
