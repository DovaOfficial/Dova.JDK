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

[JniSignatureAttribute("Lsun/security/ssl/X509TrustManagerImpl;", "final")]
public partial class X509TrustManagerImpl
	: Dova.JDK.javax.net.ssl.X509ExtendedTrustManager
	, Dova.JDK.javax.net.ssl.X509TrustManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static X509TrustManagerImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509TrustManagerImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatorType", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trustedCerts", "Ljava/util/Collection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pkixParams", "Ljava/security/cert/PKIXBuilderParameters;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientValidator", "Lsun/security/validator/Validator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverValidator", "Lsun/security/validator/Validator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validatorLock", "Ljava/util/concurrent/locks/ReentrantLock;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/Collection;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/security/cert/PKIXBuilderParameters;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValidator", "(Ljava/lang/String;)Lsun/security/validator/Validator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkTrustedInit", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Z)Lsun/security/validator/Validator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHostNameInSNI", "(Ljava/util/List;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRequestedServerNames", "(Ljavax/net/ssl/SSLSession;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRequestedServerNames", "(Ljava/net/Socket;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRequestedServerNames", "(Ljavax/net/ssl/SSLEngine;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkIdentity", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkIdentity", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkIdentity", "(Ljavax/net/ssl/SSLSession;[Ljava/security/cert/X509Certificate;Ljava/lang/String;Z)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String validatorType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Collection;", "private final")]
	public Dova.JDK.java.util.Collection trustedCerts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/cert/PKIXBuilderParameters;", "private final")]
	public Dova.JDK.java.security.cert.PKIXBuilderParameters pkixParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.PKIXBuilderParameters>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/validator/Validator;", "private volatile")]
	public Dova.JDK.sun.security.validator.Validator clientValidator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.validator.Validator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/validator/Validator;", "private volatile")]
	public Dova.JDK.sun.security.validator.Validator serverValidator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.validator.Validator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/ReentrantLock;", "private final")]
	public Dova.JDK.java.util.concurrent.locks.ReentrantLock validatorLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReentrantLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public X509TrustManagerImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)V", "")]
	public X509TrustManagerImpl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/cert/PKIXBuilderParameters;)V", "")]
	public X509TrustManagerImpl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.cert.PKIXBuilderParameters arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/X509TrustManagerImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/validator/Validator;", "private")]
	public Dova.JDK.sun.security.validator.Validator getValidator(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.validator.Validator>(ret);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;Z)V", "private")]
	public void checkTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;Z)V", "private")]
	public void checkTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Z)Lsun/security/validator/Validator;", "private")]
	public Dova.JDK.sun.security.validator.Validator checkTrustedInit(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.validator.Validator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getHostNameInSNI(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSession;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getRequestedServerNames(Dova.JDK.javax.net.ssl.SSLSession arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/Socket;)Ljava/util/List;", "static")]
	public static Dova.JDK.java.util.List getRequestedServerNames(Dova.JDK.java.net.Socket arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLEngine;)Ljava/util/List;", "static")]
	public static Dova.JDK.java.util.List getRequestedServerNames(Dova.JDK.javax.net.ssl.SSLEngine arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "public")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V", "public")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V", "public")]
	public void checkClientTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/net/Socket;)V", "public")]
	public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.net.Socket arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljavax/net/ssl/SSLEngine;)V", "public")]
	public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "public")]
	public void checkServerTrusted(JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("()[Ljava/security/cert/X509Certificate;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.X509Certificate> getAcceptedIssuers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "static")]
	public static void checkIdentity(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.cert.X509Certificate arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/cert/X509Certificate;Ljava/lang/String;Z)V", "private static")]
	public static void checkIdentity(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.cert.X509Certificate arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSession;[Ljava/security/cert/X509Certificate;Ljava/lang/String;Z)V", "static")]
	public static void checkIdentity(Dova.JDK.javax.net.ssl.SSLSession arg0, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}
}
