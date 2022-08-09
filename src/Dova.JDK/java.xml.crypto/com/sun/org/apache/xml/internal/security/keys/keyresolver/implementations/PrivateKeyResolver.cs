/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.keyresolver.implementations;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/keys/keyresolver/implementations/PrivateKeyResolver;", "public")]
public partial class PrivateKeyResolver
	: Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.keyresolver.KeyResolverSpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrivateKeyResolver()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/keys/keyresolver/implementations/PrivateKeyResolver;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LOG", "Lcom/sun/org/slf4j/internal/Logger;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "keyStore", "Ljava/security/KeyStore;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "password", "[C"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PrivateKeyResolver", "(Ljava/security/KeyStore;[C)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resolveX509Data", "(Lorg/w3c/dom/Element;Ljava/lang/String;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resolveX509SKI", "(Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509SKI;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resolveX509IssuerSerial", "(Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509IssuerSerial;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resolveX509SubjectName", "(Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509SubjectName;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resolveX509Certificate", "(Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509Certificate;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineCanResolve", "(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineResolveX509Certificate", "(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;Z)Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineResolveSecretKey", "(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;Z)Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineResolvePrivateKey", "(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;Z)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "engineResolvePublicKey", "(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;Z)Ljava/security/PublicKey;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/slf4j/internal/Logger;", "private static final")]
	public static Dova.JDK.com.sun.org.slf4j.@internal.Logger LOG_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.slf4j.@internal.Logger>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/security/KeyStore;", "private final")]
	public Dova.JDK.java.security.KeyStore keyStore_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.KeyStore>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[C", "private final")]
	public JavaArray<char> password_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrivateKeyResolver(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/security/KeyStore;[C)V", "public")]
	public PrivateKeyResolver(Dova.JDK.java.security.KeyStore arg0, JavaArray<char> arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/keys/keyresolver/implementations/PrivateKeyResolver;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;)Ljava/security/PrivateKey;", "private")]
	public Dova.JDK.java.security.PrivateKey resolveX509Data(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509SKI;)Ljava/security/PrivateKey;", "private")]
	public Dova.JDK.java.security.PrivateKey resolveX509SKI(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.x509.XMLX509SKI arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509IssuerSerial;)Ljava/security/PrivateKey;", "private")]
	public Dova.JDK.java.security.PrivateKey resolveX509IssuerSerial(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.x509.XMLX509IssuerSerial arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509SubjectName;)Ljava/security/PrivateKey;", "private")]
	public Dova.JDK.java.security.PrivateKey resolveX509SubjectName(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.x509.XMLX509SubjectName arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509Certificate;)Ljava/security/PrivateKey;", "private")]
	public Dova.JDK.java.security.PrivateKey resolveX509Certificate(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.x509.XMLX509Certificate arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;)Z", "protected")]
	public bool engineCanResolve(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.storage.StorageResolver arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;Z)Ljava/security/cert/X509Certificate;", "protected")]
	public Dova.JDK.java.security.cert.X509Certificate engineResolveX509Certificate(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.storage.StorageResolver arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;Z)Ljavax/crypto/SecretKey;", "protected")]
	public Dova.JDK.javax.crypto.SecretKey engineResolveSecretKey(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.storage.StorageResolver arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;Z)Ljava/security/PrivateKey;", "public")]
	public Dova.JDK.java.security.PrivateKey engineResolvePrivateKey(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.storage.StorageResolver arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;Z)Ljava/security/PublicKey;", "protected")]
	public Dova.JDK.java.security.PublicKey engineResolvePublicKey(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.storage.StorageResolver arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}
}