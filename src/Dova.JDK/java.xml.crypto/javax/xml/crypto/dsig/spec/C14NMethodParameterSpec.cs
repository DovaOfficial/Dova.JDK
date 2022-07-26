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

namespace Dova.JDK.javax.xml.crypto.dsig.spec;

[JniSignatureAttribute("Ljavax/xml/crypto/dsig/spec/C14NMethodParameterSpec;", "public abstract interface")]
public partial interface C14NMethodParameterSpec
	: IJavaObject
	, Dova.JDK.javax.xml.crypto.dsig.spec.TransformParameterSpec
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static C14NMethodParameterSpec()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/xml/crypto/dsig/spec/C14NMethodParameterSpec;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
