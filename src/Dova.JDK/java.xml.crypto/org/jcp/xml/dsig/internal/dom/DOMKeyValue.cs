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

[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue;", "public abstract")]
public partial class DOMKeyValue
	: Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMStructure
	, Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyValue
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMKeyValue()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XMLDSIG_11_XMLNS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "publicKey", "Ljava/security/PublicKey;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/PublicKey;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decode", "(Lorg/w3c/dom/Element;)Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPublicKey", "()Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "marshal", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unmarshal", "(Lorg/w3c/dom/Element;)Ljavax/xml/crypto/dsig/keyinfo/KeyValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyValue", "(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "marshalPublicKey", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generatePublicKey", "(Ljava/security/KeyFactory;Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bigInt", "(Ljava/lang/String;)Ljava/math/BigInteger;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String XMLDSIG_11_XMLNS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/PublicKey;", "private final")]
	public Dova.JDK.java.lang.Object publicKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DOMKeyValue(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)V", "public")]
	public DOMKeyValue(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)V", "public")]
	public DOMKeyValue(Dova.JDK.org.w3c.dom.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/math/BigInteger;", "public static")]
	public static Dova.JDK.java.math.BigInteger decode(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/PublicKey;", "public")]
	public Dova.JDK.java.security.PublicKey getPublicKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V", "public")]
	public void marshal(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.xml.crypto.dom.DOMCryptoContext arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljavax/xml/crypto/dsig/keyinfo/KeyValue;", "static")]
	public static Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyValue unmarshal(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyValue>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;", "abstract")]
	public Dova.JDK.java.lang.Object unmarshalKeyValue(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V", "abstract")]
	public void marshalPublicKey(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Document arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.xml.crypto.dom.DOMCryptoContext arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/security/KeyFactory;Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", "private static")]
	public static Dova.JDK.java.security.PublicKey generatePublicKey(Dova.JDK.java.security.KeyFactory arg0, Dova.JDK.java.security.spec.KeySpec arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/math/BigInteger;", "private static")]
	public static Dova.JDK.java.math.BigInteger bigInt(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$DSA;", "static final")]
	public partial class DSA
		: Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DSA()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$DSA;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "p", "Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "q", "Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "g", "Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y", "Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dsakf", "Ljava/security/KeyFactory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/interfaces/DSAPublicKey;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyValue_0", "(Lorg/w3c/dom/Element;)Ljava/security/interfaces/DSAPublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyValue_1", "(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "marshalPublicKey", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V"));
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;", "private")]
		public Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary p_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;", "private")]
		public Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary q_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;", "private")]
		public Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary g_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;", "private")]
		public Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary y_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/KeyFactory;", "private")]
		public Dova.JDK.java.security.KeyFactory dsakf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.KeyFactory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DSA(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/interfaces/DSAPublicKey;)V", "")]
		public DSA(Dova.JDK.java.security.interfaces.DSAPublicKey arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)V", "")]
		public DSA(Dova.JDK.org.w3c.dom.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$DSA;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/security/interfaces/DSAPublicKey;", "")]
		public Dova.JDK.java.security.interfaces.DSAPublicKey unmarshalKeyValue_0(Dova.JDK.org.w3c.dom.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.DSAPublicKey>(ret);
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;", "volatile")]
		public Dova.JDK.java.security.PublicKey unmarshalKeyValue_1(Dova.JDK.org.w3c.dom.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V", "")]
		public void marshalPublicKey(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Document arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.xml.crypto.dom.DOMCryptoContext arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$RSA;", "static final")]
	public partial class RSA
		: Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RSA()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$RSA;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modulus", "Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exponent", "Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rsakf", "Ljava/security/KeyFactory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/interfaces/RSAPublicKey;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyValue_0", "(Lorg/w3c/dom/Element;)Ljava/security/interfaces/RSAPublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyValue_1", "(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "marshalPublicKey", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V"));
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;", "private")]
		public Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary modulus_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMCryptoBinary;", "private")]
		public Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary exponent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMCryptoBinary>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/KeyFactory;", "private")]
		public Dova.JDK.java.security.KeyFactory rsakf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.KeyFactory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RSA(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/interfaces/RSAPublicKey;)V", "")]
		public RSA(Dova.JDK.java.security.interfaces.RSAPublicKey arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)V", "")]
		public RSA(Dova.JDK.org.w3c.dom.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$RSA;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/security/interfaces/RSAPublicKey;", "")]
		public Dova.JDK.java.security.interfaces.RSAPublicKey unmarshalKeyValue_0(Dova.JDK.org.w3c.dom.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.RSAPublicKey>(ret);
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;", "volatile")]
		public Dova.JDK.java.security.PublicKey unmarshalKeyValue_1(Dova.JDK.org.w3c.dom.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V", "")]
		public void marshalPublicKey(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Document arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.xml.crypto.dom.DOMCryptoContext arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC;", "static final")]
	public partial class EC
		: Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EC()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ecPublicKey", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eckf", "Ljava/security/KeyFactory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ecParams", "Ljava/security/spec/ECParameterSpec;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP256R1", "Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP384R1", "Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECP521R1", "Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/interfaces/ECPublicKey;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getECParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/ECParameterSpec;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decodePoint", "([BLjava/security/spec/EllipticCurve;)Ljava/security/spec/ECPoint;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encodePoint", "(Ljava/security/spec/ECPoint;Ljava/security/spec/EllipticCurve;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "trimZeroes", "([B)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initializeCurve", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyValue_0", "(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyValue_1", "(Lorg/w3c/dom/Element;)Ljava/security/interfaces/ECPublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "marshalPublicKey", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCurveOid", "(Ljava/security/spec/ECParameterSpec;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "matchCurve", "(Ljava/security/spec/ECParameterSpec;Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;)Z"));
		}

		[JniSignatureAttribute("[B", "private")]
		public JavaArray<byte> ecPublicKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/KeyFactory;", "private")]
		public Dova.JDK.java.security.KeyFactory eckf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.KeyFactory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/spec/ECParameterSpec;", "private")]
		public Dova.JDK.java.security.spec.ECParameterSpec ecParams_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;", "private static final")]
		public static Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue.EC.Curve SECP256R1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue.EC.Curve>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;", "private static final")]
		public static Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue.EC.Curve SECP384R1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue.EC.Curve>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;", "private static final")]
		public static Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue.EC.Curve SECP521R1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue.EC.Curve>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EC(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)V", "")]
		public EC(Dova.JDK.org.w3c.dom.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/security/interfaces/ECPublicKey;)V", "")]
		public EC(Dova.JDK.java.security.interfaces.ECPublicKey arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/security/spec/ECParameterSpec;", "private static")]
		public static Dova.JDK.java.security.spec.ECParameterSpec getECParameterSpec(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECParameterSpec>(ret);
		}

		[JniSignatureAttribute("([BLjava/security/spec/EllipticCurve;)Ljava/security/spec/ECPoint;", "private static")]
		public static Dova.JDK.java.security.spec.ECPoint decodePoint(JavaArray<byte> arg0, Dova.JDK.java.security.spec.EllipticCurve arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.ECPoint>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/spec/ECPoint;Ljava/security/spec/EllipticCurve;)[B", "private static")]
		public static JavaArray<byte> encodePoint(Dova.JDK.java.security.spec.ECPoint arg0, Dova.JDK.java.security.spec.EllipticCurve arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("([B)[B", "private static")]
		public static JavaArray<byte> trimZeroes(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;", "private static")]
		public static Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue.EC.Curve initializeCurve(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, int arg8)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue.EC.Curve>(ret);
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;", "volatile")]
		public Dova.JDK.java.security.PublicKey unmarshalKeyValue_0(Dova.JDK.org.w3c.dom.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/security/interfaces/ECPublicKey;", "")]
		public Dova.JDK.java.security.interfaces.ECPublicKey unmarshalKeyValue_1(Dova.JDK.org.w3c.dom.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.interfaces.ECPublicKey>(ret);
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V", "")]
		public void marshalPublicKey(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Document arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.xml.crypto.dom.DOMCryptoContext arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/security/spec/ECParameterSpec;)Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String getCurveOid(Dova.JDK.java.security.spec.ECParameterSpec arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/spec/ECParameterSpec;Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;)Z", "private static")]
		public static bool matchCurve(Dova.JDK.java.security.spec.ECParameterSpec arg0, Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue.EC.Curve arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;", "static final")]
		public partial class Curve
			: Dova.JDK.java.security.spec.ECParameterSpec
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Curve()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "oid", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/EllipticCurve;Ljava/security/spec/ECPoint;Ljava/math/BigInteger;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectId", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String name_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String oid_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Curve(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/EllipticCurve;Ljava/security/spec/ECPoint;Ljava/math/BigInteger;I)V", "")]
			public Curve(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.security.spec.EllipticCurve arg2, Dova.JDK.java.security.spec.ECPoint arg3, Dova.JDK.java.math.BigInteger arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$EC$Curve;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String getName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String getObjectId()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$Unknown;", "static final")]
	public partial class Unknown
		: Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMKeyValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Unknown()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$Unknown;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "externalPublicKey", "Ljavax/xml/crypto/dom/DOMStructure;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unmarshalKeyValue", "(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "marshalPublicKey", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V"));
		}

		[JniSignatureAttribute("Ljavax/xml/crypto/dom/DOMStructure;", "private")]
		public Dova.JDK.javax.xml.crypto.dom.DOMStructure externalPublicKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dom.DOMStructure>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Unknown(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)V", "")]
		public Unknown(Dova.JDK.org.w3c.dom.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMKeyValue$Unknown;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/security/PublicKey;", "")]
		public Dova.JDK.java.security.PublicKey unmarshalKeyValue(Dova.JDK.org.w3c.dom.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Document;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V", "")]
		public void marshalPublicKey(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Document arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.xml.crypto.dom.DOMCryptoContext arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		}
	}
}
