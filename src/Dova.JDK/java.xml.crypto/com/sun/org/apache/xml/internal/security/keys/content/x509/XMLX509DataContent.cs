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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.keys.content.x509;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509DataContent;", "public abstract interface")]
public partial interface XMLX509DataContent
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static XMLX509DataContent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/keys/content/x509/XMLX509DataContent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
