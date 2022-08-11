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

namespace Dova.JDK.javax.xml.crypto.dsig.keyinfo;

[JniSignatureAttribute("Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;", "public abstract")]
public partial class KeyInfoFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyInfoFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mechanismType", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "provider", "Ljava/security/Provider;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvider", "()Ljava/security/Provider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFeatureSupported", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURIDereferencer", "()Ljavax/xml/crypto/URIDereferencer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newKeyInfo", "(Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newKeyInfo", "(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newPGPData", "([BLjava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/PGPData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newPGPData", "([B)Ljavax/xml/crypto/dsig/keyinfo/PGPData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newPGPData", "([B[BLjava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/PGPData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newRetrievalMethod", "(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/RetrievalMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newRetrievalMethod", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/RetrievalMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newKeyName", "(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newKeyValue", "(Ljava/security/PublicKey;)Ljavax/xml/crypto/dsig/keyinfo/KeyValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newX509Data", "(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/X509Data;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newX509IssuerSerial", "(Ljava/lang/String;Ljava/math/BigInteger;)Ljavax/xml/crypto/dsig/keyinfo/X509IssuerSerial;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyInfo", "(Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;"));
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
	public KeyInfoFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public KeyInfoFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;", "public static")]
	public static Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;", "public static")]
	public static Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory getInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/security/Provider;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;", "public static")]
	public static Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory getInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.security.Provider arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;", "public static")]
	public static Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory getInstance(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/Provider;", "public final")]
	public Dova.JDK.java.security.Provider getProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Provider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public abstract")]
	public bool isFeatureSupported(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/xml/crypto/URIDereferencer;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.URIDereferencer getURIDereferencer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.URIDereferencer>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo newKeyInfo(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo newKeyInfo(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo>(ret);
	}

	[JniSignatureAttribute("([BLjava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/PGPData;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData newPGPData(JavaArray<byte> arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData>(ret);
	}

	[JniSignatureAttribute("([B)Ljavax/xml/crypto/dsig/keyinfo/PGPData;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData newPGPData(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData>(ret);
	}

	[JniSignatureAttribute("([B[BLjava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/PGPData;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData newPGPData(JavaArray<byte> arg0, JavaArray<byte> arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/RetrievalMethod;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.RetrievalMethod newRetrievalMethod(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.RetrievalMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/RetrievalMethod;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.RetrievalMethod newRetrievalMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.RetrievalMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyName;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyName newKeyName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyName>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)Ljavax/xml/crypto/dsig/keyinfo/KeyValue;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyValue newKeyValue(Dova.JDK.java.security.PublicKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyValue>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/X509Data;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.X509Data newX509Data(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.X509Data>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/math/BigInteger;)Ljavax/xml/crypto/dsig/keyinfo/X509IssuerSerial;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.X509IssuerSerial newX509IssuerSerial(Dova.JDK.java.lang.String arg0, Dova.JDK.java.math.BigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.X509IssuerSerial>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;", "public abstract")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo unmarshalKeyInfo(Dova.JDK.javax.xml.crypto.XMLStructure arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getMechanismType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
