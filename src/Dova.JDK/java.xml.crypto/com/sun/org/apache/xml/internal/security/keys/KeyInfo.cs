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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.keys;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/keys/KeyInfo;", "public")]
public partial class KeyInfo
	: Dova.JDK.com.sun.org.apache.xml.@internal.security.utils.SignatureElementProxy
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/keys/KeyInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOG", "Lcom/sun/org/slf4j/internal/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x509Datas", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nullList", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "storageResolvers", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalKeyResolvers", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "secureValidation", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Document;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/SPKIData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/KeyValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/security/PublicKey;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/keyvalues/RSAKeyValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/MgmtData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/PGPData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/RetrievalMethod;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/KeyInfoReference;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/KeyName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/DEREncodedKeyValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/keyvalues/DSAKeyValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xml/internal/security/keys/content/X509Data;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getId", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPublicKey", "()Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX509CertificateFromStaticResolvers", "()Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyCurrentResolver", "(Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/keyresolver/KeyResolverSpi;)Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerInternalKeyResolver", "(Lcom/sun/org/apache/xml/internal/security/keys/keyresolver/KeyResolverSpi;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemInternalKeyResolver", "(I)Lcom/sun/org/apache/xml/internal/security/keys/keyresolver/KeyResolverSpi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsMgmtData", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsPGPData", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsSPKIData", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsUnknownElement", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPublicKeyFromStaticResolvers", "()Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemKeyInfoReference", "(I)Lcom/sun/org/apache/xml/internal/security/keys/content/KeyInfoReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsKeyValue", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthDEREncodedKeyValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthKeyInfoReference", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPublicKeyFromInternalResolvers", "()Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX509CertificateFromInternalResolvers", "()Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMgmtData", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addKeyName", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemKeyName", "(I)Lcom/sun/org/apache/xml/internal/security/keys/content/KeyName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemKeyValue", "(I)Lcom/sun/org/apache/xml/internal/security/keys/content/KeyValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addKeyInfoReference", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addUnknownElement", "(Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrivateKeyFromStaticResolvers", "()Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDEREncodedKeyValue", "(Ljava/security/PublicKey;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemX509Data", "(I)Lcom/sun/org/apache/xml/internal/security/keys/content/X509Data;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemDEREncodedKeyValue", "(I)Lcom/sun/org/apache/xml/internal/security/keys/content/DEREncodedKeyValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecretKeyFromStaticResolvers", "()Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemUnknownElement", "(I)Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsKeyName", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRetrievalMethod", "(Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/transforms/Transforms;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addKeyValue", "(Ljava/security/PublicKey;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addKeyValue", "(Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemMgmtData", "(I)Lcom/sun/org/apache/xml/internal/security/keys/content/MgmtData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthKeyName", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsX509Data", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsDEREncodedKeyValue", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthInternalKeyResolver", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecretKeyFromInternalResolvers", "()Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthSPKIData", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthUnknownElement", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthX509Data", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemSPKIData", "(I)Lcom/sun/org/apache/xml/internal/security/keys/content/SPKIData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrivateKeyFromInternalResolvers", "()Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthKeyValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthMgmtData", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthPGPData", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthRetrievalMethod", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemPGPData", "(I)Lcom/sun/org/apache/xml/internal/security/keys/content/PGPData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemRetrievalMethod", "(I)Lcom/sun/org/apache/xml/internal/security/keys/content/RetrievalMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrivateKey", "()Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecretKey", "()Ljavax/crypto/SecretKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX509Certificate", "()Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSecureValidation", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addStorageResolver", "(Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsKeyInfoReference", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsRetrievalMethod", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseLocalName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setId", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/org/slf4j/internal/Logger;", "private static final")]
	public static Dova.JDK.com.sun.org.slf4j.@internal.Logger LOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.slf4j.@internal.Logger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List x509Datas_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private static final")]
	public static Dova.JDK.java.util.List nullList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List storageResolvers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List internalKeyResolvers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool secureValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Document;)V", "public")]
	public KeyInfo(Dova.JDK.org.w3c.dom.Document arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;)V", "public")]
	public KeyInfo(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/keys/KeyInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/SPKIData;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.SPKIData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/KeyValue;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.KeyValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)V", "public")]
	public void add(Dova.JDK.java.security.PublicKey arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/keyvalues/RSAKeyValue;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.keyvalues.RSAKeyValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/MgmtData;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.MgmtData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/PGPData;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.PGPData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/RetrievalMethod;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.RetrievalMethod arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/KeyInfoReference;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.KeyInfoReference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/KeyName;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.KeyName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/DEREncodedKeyValue;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.DEREncodedKeyValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/keyvalues/DSAKeyValue;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.keyvalues.DSAKeyValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/content/X509Data;)V", "public")]
	public void add(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.X509Data arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/PublicKey;", "public")]
	public Dova.JDK.java.security.PublicKey getPublicKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/cert/X509Certificate;", "")]
	public Dova.JDK.java.security.cert.X509Certificate getX509CertificateFromStaticResolvers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/keys/keyresolver/KeyResolverSpi;)Ljava/security/cert/X509Certificate;", "private")]
	public Dova.JDK.java.security.cert.X509Certificate applyCurrentResolver(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.keyresolver.KeyResolverSpi arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/keyresolver/KeyResolverSpi;)V", "public")]
	public void registerInternalKeyResolver(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.keyresolver.KeyResolverSpi arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/keyresolver/KeyResolverSpi;", "")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.keyresolver.KeyResolverSpi itemInternalKeyResolver(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.keyresolver.KeyResolverSpi>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsMgmtData()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsPGPData()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsSPKIData()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsUnknownElement()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/security/PublicKey;", "")]
	public Dova.JDK.java.security.PublicKey getPublicKeyFromStaticResolvers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/content/KeyInfoReference;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.KeyInfoReference itemKeyInfoReference(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.KeyInfoReference>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsKeyValue()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthDEREncodedKeyValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthKeyInfoReference()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/security/PublicKey;", "")]
	public Dova.JDK.java.security.PublicKey getPublicKeyFromInternalResolvers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/cert/X509Certificate;", "")]
	public Dova.JDK.java.security.cert.X509Certificate getX509CertificateFromInternalResolvers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void addMgmtData(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void addKeyName(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/content/KeyName;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.KeyName itemKeyName(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.KeyName>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/content/KeyValue;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.KeyValue itemKeyValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.KeyValue>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void addKeyInfoReference(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)V", "public")]
	public void addUnknownElement(Dova.JDK.org.w3c.dom.Element arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("()Ljava/security/PrivateKey;", "")]
	public Dova.JDK.java.security.PrivateKey getPrivateKeyFromStaticResolvers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)V", "public")]
	public void addDEREncodedKeyValue(Dova.JDK.java.security.PublicKey arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/content/X509Data;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.X509Data itemX509Data(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.X509Data>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/content/DEREncodedKeyValue;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.DEREncodedKeyValue itemDEREncodedKeyValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.DEREncodedKeyValue>(ret);
	}

	[JniSignatureAttribute("()Ljavax/crypto/SecretKey;", "")]
	public Dova.JDK.javax.crypto.SecretKey getSecretKeyFromStaticResolvers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("(I)Lorg/w3c/dom/Element;", "public")]
	public Dova.JDK.org.w3c.dom.Element itemUnknownElement(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsKeyName()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/transforms/Transforms;Ljava/lang/String;)V", "public")]
	public void addRetrievalMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xml.@internal.security.transforms.Transforms arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)V", "public")]
	public void addKeyValue(Dova.JDK.java.security.PublicKey arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)V", "public")]
	public void addKeyValue(Dova.JDK.org.w3c.dom.Element arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/content/MgmtData;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.MgmtData itemMgmtData(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.MgmtData>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthKeyName()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[47]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsX509Data()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[48]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsDEREncodedKeyValue()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49]);
		return ret;
	}

	[JniSignatureAttribute("()I", "")]
	public int lengthInternalKeyResolver()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[50]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/crypto/SecretKey;", "")]
	public Dova.JDK.javax.crypto.SecretKey getSecretKeyFromInternalResolvers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthSPKIData()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[52]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthUnknownElement()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[53]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthX509Data()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[54]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/content/SPKIData;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.SPKIData itemSPKIData(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.SPKIData>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/PrivateKey;", "")]
	public Dova.JDK.java.security.PrivateKey getPrivateKeyFromInternalResolvers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthKeyValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[57]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthMgmtData()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[58]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthPGPData()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[59]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthRetrievalMethod()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[60]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/content/PGPData;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.PGPData itemPGPData(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.PGPData>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/security/keys/content/RetrievalMethod;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.RetrievalMethod itemRetrievalMethod(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.RetrievalMethod>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/PrivateKey;", "public")]
	public Dova.JDK.java.security.PrivateKey getPrivateKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("()Ljavax/crypto/SecretKey;", "public")]
	public Dova.JDK.javax.crypto.SecretKey getSecretKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/cert/X509Certificate;", "public")]
	public Dova.JDK.java.security.cert.X509Certificate getX509Certificate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setSecureValidation(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/keys/storage/StorageResolver;)V", "public")]
	public void addStorageResolver(Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.storage.StorageResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsKeyInfoReference()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[68]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool containsRetrievalMethod()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getBaseLocalName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setId(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
	}
}
