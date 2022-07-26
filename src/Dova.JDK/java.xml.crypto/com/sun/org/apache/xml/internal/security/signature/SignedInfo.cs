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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.signature;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/signature/SignedInfo;", "public")]
public partial class SignedInfo
	: Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Manifest
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SignedInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/signature/SignedInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureAlgorithm", "Lcom/sun/org/apache/xml/internal/security/algorithms/SignatureAlgorithm;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "c14nizedBytes", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "c14nMethod", "Lorg/w3c/dom/Element;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureMethod", "Lorg/w3c/dom/Element;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Document;Lorg/w3c/dom/Element;Lorg/w3c/dom/Element;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Document;Lorg/w3c/dom/Element;Lorg/w3c/dom/Element;Ljava/security/Provider;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;Ljava/lang/String;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;Ljava/lang/String;ZLjava/security/Provider;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Document;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/security/Provider;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Document;Ljava/lang/String;ILjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Document;Ljava/lang/String;ILjava/lang/String;Ljava/security/Provider;Ljava/security/spec/AlgorithmParameterSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseLocalName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInclusiveNamespaces", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignatureAlgorithm", "()Lcom/sun/org/apache/xml/internal/security/algorithms/SignatureAlgorithm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignatureMethodElement", "()Lorg/w3c/dom/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalizationMethodURI", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalizedOctetStream", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signInOctetStream", "(Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignatureMethodURI", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSecretKey", "([B)Ljavax/crypto/SecretKey;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/algorithms/SignatureAlgorithm;", "private final")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.SignatureAlgorithm signatureAlgorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.SignatureAlgorithm>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> c14nizedBytes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element c14nMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Element;", "private")]
	public Dova.JDK.org.w3c.dom.Element signatureMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SignedInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Document;Lorg/w3c/dom/Element;Lorg/w3c/dom/Element;)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Document arg0, Dova.JDK.org.w3c.dom.Element arg1, Dova.JDK.org.w3c.dom.Element arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Document;Lorg/w3c/dom/Element;Lorg/w3c/dom/Element;Ljava/security/Provider;)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Document arg0, Dova.JDK.org.w3c.dom.Element arg1, Dova.JDK.org.w3c.dom.Element arg2, Dova.JDK.java.security.Provider arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;Z)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;ZLjava/security/Provider;)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.security.Provider arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Document;)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Document arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Document arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Document;Ljava/lang/String;Ljava/lang/String;Ljava/security/Provider;)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Document arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.security.Provider arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[7], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Document;Ljava/lang/String;ILjava/lang/String;)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Document arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[8], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Document;Ljava/lang/String;ILjava/lang/String;Ljava/security/Provider;Ljava/security/spec/AlgorithmParameterSpec;)V", "public")]
	public SignedInfo(Dova.JDK.org.w3c.dom.Document arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.security.Provider arg4, Dova.JDK.java.security.spec.AlgorithmParameterSpec arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/signature/SignedInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Z)Z", "public")]
	public bool verify(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool verify()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getBaseLocalName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getInclusiveNamespaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/security/algorithms/SignatureAlgorithm;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.SignatureAlgorithm getSignatureAlgorithm()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.algorithms.SignatureAlgorithm>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Element;", "public")]
	public Dova.JDK.org.w3c.dom.Element getSignatureMethodElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Element>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getCanonicalizationMethodURI()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getCanonicalizedOctetStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)V", "public")]
	public void signInOctetStream(Dova.JDK.java.io.OutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSignatureMethodURI()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([B)Ljavax/crypto/SecretKey;", "public")]
	public Dova.JDK.javax.crypto.SecretKey createSecretKey(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.SecretKey>(ret);
	}
}
