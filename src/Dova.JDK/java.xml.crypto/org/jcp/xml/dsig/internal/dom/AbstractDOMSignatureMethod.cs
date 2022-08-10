/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod;", "abstract")]
public partial class AbstractDOMSignatureMethod
	: Dova.JDK.org.jcp.xml.dsig.@internal.dom.DOMStructure
	, Dova.JDK.javax.xml.crypto.dsig.SignatureMethod
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractDOMSignatureMethod()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AbstractDOMSignatureMethod", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sign", "(Ljava/security/Key;Ljavax/xml/crypto/dsig/SignedInfo;Ljavax/xml/crypto/dsig/XMLSignContext;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "verify", "(Ljava/security/Key;Ljavax/xml/crypto/dsig/SignedInfo;[BLjavax/xml/crypto/dsig/XMLValidateContext;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "marshal", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "marshalParams", "(Lorg/w3c/dom/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "paramsEqual", "(Ljava/security/spec/AlgorithmParameterSpec;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getJCAAlgorithm", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAlgorithmType", "()Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unmarshalParams", "(Lorg/w3c/dom/Element;)Ljavax/xml/crypto/dsig/spec/SignatureMethodParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkParams", "(Ljavax/xml/crypto/dsig/spec/SignatureMethodParameterSpec;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractDOMSignatureMethod(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public AbstractDOMSignatureMethod() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod;";
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

	[JniSignatureAttribute("(Ljava/security/Key;Ljavax/xml/crypto/dsig/SignedInfo;Ljavax/xml/crypto/dsig/XMLSignContext;)[B", "abstract")]
	public JavaArray<byte> sign(Dova.JDK.java.security.Key arg0, Dova.JDK.javax.xml.crypto.dsig.SignedInfo arg1, Dova.JDK.javax.xml.crypto.dsig.XMLSignContext arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljavax/xml/crypto/dsig/SignedInfo;[BLjavax/xml/crypto/dsig/XMLValidateContext;)Z", "abstract")]
	public bool verify(Dova.JDK.java.security.Key arg0, Dova.JDK.javax.xml.crypto.dsig.SignedInfo arg1, JavaArray<byte> arg2, Dova.JDK.javax.xml.crypto.dsig.XMLValidateContext arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;Ljavax/xml/crypto/dom/DOMCryptoContext;)V", "public")]
	public void marshal(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.xml.crypto.dom.DOMCryptoContext arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;)V", "")]
	public void marshalParams(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/spec/AlgorithmParameterSpec;)Z", "")]
	public bool paramsEqual(Dova.JDK.java.security.spec.AlgorithmParameterSpec arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "abstract")]
	public Dova.JDK.java.lang.String getJCAAlgorithm()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "abstract")]
	public Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type getAlgorithmType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljavax/xml/crypto/dsig/spec/SignatureMethodParameterSpec;", "")]
	public Dova.JDK.javax.xml.crypto.dsig.spec.SignatureMethodParameterSpec unmarshalParams(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.spec.SignatureMethodParameterSpec>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/spec/SignatureMethodParameterSpec;)V", "")]
	public void checkParams(Dova.JDK.javax.xml.crypto.dsig.spec.SignatureMethodParameterSpec arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "static final")]
	public partial class Type
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Type()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DSA", "Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RSA", "Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ECDSA", "Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HMAC", "Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Type", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;"));
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "public static final")]
		public static Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type DSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "public static final")]
		public static Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type RSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "public static final")]
		public static Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type ECDSA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "public static final")]
		public static Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type HMAC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "private static final")]
		public static JavaArray<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Type(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Type(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "public static")]
		public static JavaArray<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "public static")]
		public static Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type>(ret);
		}

		[JniSignatureAttribute("()[Lorg/jcp/xml/dsig/internal/dom/AbstractDOMSignatureMethod$Type;", "private static")]
		public static JavaArray<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.jcp.xml.dsig.@internal.dom.AbstractDOMSignatureMethod.Type>>(ret);
		}
	}
}
