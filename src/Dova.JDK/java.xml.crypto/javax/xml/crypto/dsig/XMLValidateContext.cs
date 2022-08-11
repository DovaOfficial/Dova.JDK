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

[JniSignatureAttribute("Ljavax/xml/crypto/dsig/XMLValidateContext;", "public abstract interface")]
public partial interface XMLValidateContext
	: IJavaObject
	, Dova.JDK.javax.xml.crypto.XMLCryptoContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static XMLValidateContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/dsig/XMLValidateContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
