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

[JniSignatureAttribute("Ljavax/xml/crypto/dsig/XMLSignature;", "public abstract interface")]
public partial interface XMLSignature
	: IJavaObject
	, Dova.JDK.javax.xml.crypto.XMLStructure
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLSignature()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/dsig/XMLSignature;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XMLNS", "Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "(Ljavax/xml/crypto/dsig/XMLValidateContext;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getId", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sign", "(Ljavax/xml/crypto/dsig/XMLSignContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignedInfo", "()Ljavax/xml/crypto/dsig/SignedInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjects", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignatureValue", "()Ljavax/xml/crypto/dsig/XMLSignature$SignatureValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyInfo", "()Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeySelectorResult", "()Ljavax/xml/crypto/KeySelectorResult;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String XMLNS_Property
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

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/XMLValidateContext;)Z", "public abstract")]
	bool validate(Dova.JDK.javax.xml.crypto.dsig.XMLValidateContext arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/XMLSignContext;)V", "public abstract")]
	void sign(Dova.JDK.javax.xml.crypto.dsig.XMLSignContext arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljavax/xml/crypto/dsig/SignedInfo;", "public abstract")]
	Dova.JDK.javax.xml.crypto.dsig.SignedInfo getSignedInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.SignedInfo>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getObjects()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/crypto/dsig/XMLSignature$SignatureValue;", "public abstract")]
	Dova.JDK.javax.xml.crypto.dsig.XMLSignature.SignatureValue getSignatureValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.XMLSignature.SignatureValue>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;", "public abstract")]
	Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo getKeyInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.dsig.keyinfo.KeyInfo>(ret);
	}

	[JniSignatureAttribute("()Ljavax/xml/crypto/KeySelectorResult;", "public abstract")]
	Dova.JDK.javax.xml.crypto.KeySelectorResult getKeySelectorResult()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.KeySelectorResult>(ret);
	}

	[JniSignatureAttribute("Ljavax/xml/crypto/dsig/XMLSignature$SignatureValue;", "public abstract static interface")]
	public partial interface SignatureValue
		: IJavaObject
		, Dova.JDK.javax.xml.crypto.XMLStructure
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SignatureValue()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/dsig/XMLSignature$SignatureValue;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "(Ljavax/xml/crypto/dsig/XMLValidateContext;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getId", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("()[B", "public abstract")]
		JavaArray<byte> getValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/XMLValidateContext;)Z", "public abstract")]
		bool validate(Dova.JDK.javax.xml.crypto.dsig.XMLValidateContext arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getId()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
