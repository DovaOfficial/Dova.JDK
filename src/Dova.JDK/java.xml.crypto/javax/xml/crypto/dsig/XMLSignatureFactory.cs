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

namespace Dova.JDK.javax.xml.crypto.dsig;

[JniSignatureAttribute("Ljavax/xml/crypto/dsig/XMLSignatureFactory;", "public abstract")]
public partial class XMLSignatureFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLSignatureFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/dsig/XMLSignatureFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mechanismType", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "provider", "Ljava/security/Provider;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Ljavax/xml/crypto/dsig/XMLSignatureFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/XMLSignatureFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/xml/crypto/dsig/XMLSignatureFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;)Ljavax/xml/crypto/dsig/XMLSignatureFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvider", "()Ljava/security/Provider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyInfoFactory", "()Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newManifest", "(Ljava/util/List;)Ljavax/xml/crypto/dsig/Manifest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newManifest", "(Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/Manifest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFeatureSupported", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURIDereferencer", "()Ljavax/xml/crypto/URIDereferencer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newXMLSignature", "(Ljavax/xml/crypto/dsig/SignedInfo;Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;)Ljavax/xml/crypto/dsig/XMLSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newXMLSignature", "(Ljavax/xml/crypto/dsig/SignedInfo;Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/XMLSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newXMLObject", "(Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/XMLObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSignatureProperties", "(Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/SignatureProperties;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSignatureProperty", "(Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/SignatureProperty;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalXMLSignature", "(Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/XMLSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalXMLSignature", "(Ljavax/xml/crypto/dsig/XMLValidateContext;)Ljavax/xml/crypto/dsig/XMLSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDigestMethod", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/DigestMethodParameterSpec;)Ljavax/xml/crypto/dsig/DigestMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSignatureMethod", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/SignatureMethodParameterSpec;)Ljavax/xml/crypto/dsig/SignatureMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newTransform", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/TransformParameterSpec;)Ljavax/xml/crypto/dsig/Transform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newTransform", "(Ljava/lang/String;Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/Transform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCanonicalizationMethod", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/C14NMethodParameterSpec;)Ljavax/xml/crypto/dsig/CanonicalizationMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCanonicalizationMethod", "(Ljava/lang/String;Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/CanonicalizationMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newReference", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/DigestMethod;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;[B)Ljavax/xml/crypto/dsig/Reference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newReference", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/DigestMethod;Ljava/util/List;Ljavax/xml/crypto/Data;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/Reference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newReference", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/DigestMethod;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/Reference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newReference", "(Ljava/lang/String;Ljavax/xml/crypto/dsig/DigestMethod;)Ljavax/xml/crypto/dsig/Reference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSignedInfo", "(Ljavax/xml/crypto/dsig/CanonicalizationMethod;Ljavax/xml/crypto/dsig/SignatureMethod;Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/SignedInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSignedInfo", "(Ljavax/xml/crypto/dsig/CanonicalizationMethod;Ljavax/xml/crypto/dsig/SignatureMethod;Ljava/util/List;)Ljavax/xml/crypto/dsig/SignedInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMechanismType", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String mechanismType_Property
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

	[JniSignatureAttribute("Ljava/security/Provider;", "private")]
	public Dova.JDK.java.security.Provider provider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMLSignatureFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public XMLSignatureFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/xml/crypto/dsig/XMLSignatureFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/xml/crypto/dsig/XMLSignatureFactory;", "public static")]
	public static Dova.JDK.javax.xml.crypto.dsig.XMLSignatureFactory getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLSignatureFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/XMLSignatureFactory;", "public static")]
	public static Dova.JDK.javax.xml.crypto.dsig.XMLSignatureFactory getInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLSignatureFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/Provider;)Ljavax/xml/crypto/dsig/XMLSignatureFactory;", "public static")]
	public static Dova.JDK.javax.xml.crypto.dsig.XMLSignatureFactory getInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.Provider arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLSignatureFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/crypto/dsig/XMLSignatureFactory;", "public static")]
	public static Dova.JDK.javax.xml.crypto.dsig.XMLSignatureFactory getInstance(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLSignatureFactory>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/Provider;", "public final")]
	public Dova.JDK.java.security.Provider getProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;", "public final")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory getKeyInfoFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljavax/xml/crypto/dsig/Manifest;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.Manifest newManifest(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.Manifest>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/Manifest;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.Manifest newManifest(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.Manifest>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public abstract")]
	public bool isFeatureSupported(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/xml/crypto/URIDereferencer;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.URIDereferencer getURIDereferencer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.URIDereferencer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/SignedInfo;Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;)Ljavax/xml/crypto/dsig/XMLSignature;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.XMLSignature newXMLSignature(Dova.JDK.javax.xml.crypto.dsig.SignedInfo arg0, Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLSignature>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/SignedInfo;Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/XMLSignature;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.XMLSignature newXMLSignature(Dova.JDK.javax.xml.crypto.dsig.SignedInfo arg0, Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLSignature>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/XMLObject;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.XMLObject newXMLObject(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLObject>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/SignatureProperties;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.SignatureProperties newSignatureProperties(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.SignatureProperties>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/SignatureProperty;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.SignatureProperty newSignatureProperty(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.SignatureProperty>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/XMLSignature;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.XMLSignature unmarshalXMLSignature(Dova.JDK.javax.xml.crypto.XMLStructure arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLSignature>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/XMLValidateContext;)Ljavax/xml/crypto/dsig/XMLSignature;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.XMLSignature unmarshalXMLSignature(Dova.JDK.javax.xml.crypto.dsig.XMLValidateContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLSignature>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/DigestMethodParameterSpec;)Ljavax/xml/crypto/dsig/DigestMethod;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.DigestMethod newDigestMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.spec.DigestMethodParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.DigestMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/SignatureMethodParameterSpec;)Ljavax/xml/crypto/dsig/SignatureMethod;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.SignatureMethod newSignatureMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.spec.SignatureMethodParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.SignatureMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/TransformParameterSpec;)Ljavax/xml/crypto/dsig/Transform;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.Transform newTransform(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.spec.TransformParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.Transform>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/Transform;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.Transform newTransform(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.XMLStructure arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.Transform>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/spec/C14NMethodParameterSpec;)Ljavax/xml/crypto/dsig/CanonicalizationMethod;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.CanonicalizationMethod newCanonicalizationMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.spec.C14NMethodParameterSpec arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.CanonicalizationMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/CanonicalizationMethod;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.CanonicalizationMethod newCanonicalizationMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.XMLStructure arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.CanonicalizationMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/DigestMethod;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;[B)Ljavax/xml/crypto/dsig/Reference;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.Reference newReference(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.DigestMethod arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<byte> arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.Reference>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/DigestMethod;Ljava/util/List;Ljavax/xml/crypto/Data;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/Reference;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.Reference newReference(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.DigestMethod arg1, Dova.JDK.java.util.List arg2, Dova.JDK.javax.xml.crypto.Data arg3, Dova.JDK.java.util.List arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.Reference>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/DigestMethod;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/Reference;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.Reference newReference(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.DigestMethod arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.Reference>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/xml/crypto/dsig/DigestMethod;)Ljavax/xml/crypto/dsig/Reference;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.Reference newReference(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.xml.crypto.dsig.DigestMethod arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.Reference>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/CanonicalizationMethod;Ljavax/xml/crypto/dsig/SignatureMethod;Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/SignedInfo;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.SignedInfo newSignedInfo(Dova.JDK.javax.xml.crypto.dsig.CanonicalizationMethod arg0, Dova.JDK.javax.xml.crypto.dsig.SignatureMethod arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.SignedInfo>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/CanonicalizationMethod;Ljavax/xml/crypto/dsig/SignatureMethod;Ljava/util/List;)Ljavax/xml/crypto/dsig/SignedInfo;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.SignedInfo newSignedInfo(Dova.JDK.javax.xml.crypto.dsig.CanonicalizationMethod arg0, Dova.JDK.javax.xml.crypto.dsig.SignatureMethod arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.SignedInfo>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getMechanismType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
