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

[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMTransform;", "public")]
public partial class DOMTransform
	: Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMStructure
	, Dova.JDK.javax.xml.crypto.dsig.Transform
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMTransform()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMTransform;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spi", "Ljavax/xml/crypto/dsig/TransformService;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/xml/crypto/dsig/TransformService;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;Ljavax/xml/crypto/XMLCryptoContext;Ljava/security/Provider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljavax/xml/crypto/Data;Ljavax/xml/crypto/XMLCryptoContext;Ljavax/xml/crypto/dsig/dom/DOMSignContext;)Ljavax/xml/crypto/Data;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljavax/xml/crypto/Data;Ljavax/xml/crypto/XMLCryptoContext;Ljava/io/OutputStream;)Ljavax/xml/crypto/Data;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljavax/xml/crypto/Data;Ljavax/xml/crypto/XMLCryptoContext;)Ljavax/xml/crypto/Data;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "marshal", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterSpec", "()Ljava/security/spec/AlgorithmParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlgorithm", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljavax/xml/crypto/dsig/TransformService;", "protected")]
	public Dova.JDK.javax.xml.crypto.dsig.TransformService spi_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.TransformService>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DOMTransform(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/TransformService;)V", "public")]
	public DOMTransform(Dova.JDK.javax.xml.crypto.dsig.TransformService arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljavax/xml/crypto/XMLCryptoContext;Ljava/security/Provider;)V", "public")]
	public DOMTransform(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.javax.xml.crypto.XMLCryptoContext arg1, Dova.JDK.java.security.Provider arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMTransform;";
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

	[JniSignatureAttribute("(Ljavax/xml/crypto/Data;Ljavax/xml/crypto/XMLCryptoContext;Ljavax/xml/crypto/dsig/dom/DOMSignContext;)Ljavax/xml/crypto/Data;", "")]
	public Dova.JDK.javax.xml.crypto.Data transform(Dova.JDK.javax.xml.crypto.Data arg0, Dova.JDK.javax.xml.crypto.XMLCryptoContext arg1, Dova.JDK.javax.xml.crypto.dsig.dom.DOMSignContext arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.Data>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/Data;Ljavax/xml/crypto/XMLCryptoContext;Ljava/io/OutputStream;)Ljavax/xml/crypto/Data;", "public")]
	public Dova.JDK.javax.xml.crypto.Data transform(Dova.JDK.javax.xml.crypto.Data arg0, Dova.JDK.javax.xml.crypto.XMLCryptoContext arg1, Dova.JDK.java.io.OutputStream arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.Data>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/Data;Ljavax/xml/crypto/XMLCryptoContext;)Ljavax/xml/crypto/Data;", "public")]
	public Dova.JDK.javax.xml.crypto.Data transform(Dova.JDK.javax.xml.crypto.Data arg0, Dova.JDK.javax.xml.crypto.XMLCryptoContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.Data>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V", "public")]
	public void marshal(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.xml.crypto.dom.DOMCryptoContext arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/security/spec/AlgorithmParameterSpec;", "public final")]
	public Dova.JDK.java.security.spec.AlgorithmParameterSpec getParameterSpec()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.AlgorithmParameterSpec>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getAlgorithm()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
