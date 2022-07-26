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

namespace Dova.JDK.org.jcp.xml.dsig.@internal.dom;

[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyInfoFactory;", "public final")]
public partial class DOMKeyInfoFactory
	: Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfoFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMKeyInfoFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMKeyInfoFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFeatureSupported", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getURIDereferencer", "()Ljavax/xml/crypto/URIDereferencer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newKeyInfo", "(Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newKeyInfo", "(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newPGPData", "([B[BLjava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/PGPData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newPGPData", "([BLjava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/PGPData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newPGPData", "([B)Ljavax/xml/crypto/dsig/keyinfo/PGPData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newRetrievalMethod", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/RetrievalMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newRetrievalMethod", "(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/RetrievalMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newKeyName", "(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newKeyValue", "(Ljava/security/PublicKey;)Ljavax/xml/crypto/dsig/keyinfo/KeyValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newX509Data", "(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/X509Data;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newX509IssuerSerial", "(Ljava/lang/String;Ljava/math/BigInteger;)Ljavax/xml/crypto/dsig/keyinfo/X509IssuerSerial;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyInfo", "(Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DOMKeyInfoFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DOMKeyInfoFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMKeyInfoFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool isFeatureSupported(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/xml/crypto/URIDereferencer;", "public")]
	public Dova.JDK.javax.xml.crypto.URIDereferencer getURIDereferencer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.URIDereferencer>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo newKeyInfo(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo newKeyInfo(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo>(ret);
	}

	[JniSignatureAttribute("([B[BLjava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/PGPData;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData newPGPData(JavaArray<byte> arg0, JavaArray<byte> arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData>(ret);
	}

	[JniSignatureAttribute("([BLjava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/PGPData;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData newPGPData(JavaArray<byte> arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData>(ret);
	}

	[JniSignatureAttribute("([B)Ljavax/xml/crypto/dsig/keyinfo/PGPData;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData newPGPData(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.PGPData>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/RetrievalMethod;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.RetrievalMethod newRetrievalMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.RetrievalMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/RetrievalMethod;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.RetrievalMethod newRetrievalMethod(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.RetrievalMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyName;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyName newKeyName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyName>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)Ljavax/xml/crypto/dsig/keyinfo/KeyValue;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyValue newKeyValue(Dova.JDK.java.security.PublicKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyValue>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/X509Data;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.X509Data newX509Data(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.X509Data>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/math/BigInteger;)Ljavax/xml/crypto/dsig/keyinfo/X509IssuerSerial;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.X509IssuerSerial newX509IssuerSerial(Dova.JDK.java.lang.String arg0, Dova.JDK.java.math.BigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.X509IssuerSerial>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;", "public")]
	public Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo unmarshalKeyInfo(Dova.JDK.javax.xml.crypto.XMLStructure arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo>(ret);
	}

	[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyInfoFactory$UnmarshalContext;", "private static")]
	public partial class UnmarshalContext
		: Dova.JDK.javax.xml.crypto.dom.DOMCryptoContext
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnmarshalContext()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMKeyInfoFactory$UnmarshalContext;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnmarshalContext(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public UnmarshalContext() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMKeyInfoFactory$UnmarshalContext;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
