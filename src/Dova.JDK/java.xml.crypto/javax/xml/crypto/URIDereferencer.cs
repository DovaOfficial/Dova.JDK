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

namespace Dova.JDK.javax.xml.crypto;

[JniSignatureAttribute("Ljavax/xml/crypto/URIDereferencer;", "public abstract interface")]
public partial interface URIDereferencer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static URIDereferencer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/URIDereferencer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dereference", "(Ljavax/xml/crypto/URIReference;Ljavax/xml/crypto/XMLCryptoContext;)Ljavax/xml/crypto/Data;"));
	}

	[JniSignatureAttribute("(Ljavax/xml/crypto/URIReference;Ljavax/xml/crypto/XMLCryptoContext;)Ljavax/xml/crypto/Data;", "public abstract")]
	Dova.JDK.javax.xml.crypto.Data dereference(Dova.JDK.javax.xml.crypto.URIReference arg0, Dova.JDK.javax.xml.crypto.XMLCryptoContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.crypto.Data>(ret);
	}
}
