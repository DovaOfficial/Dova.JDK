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

namespace Dova.JDK.javax.print.attribute;

[JniSignatureAttribute("Ljavax/print/attribute/PrintRequestAttribute;", "public abstract interface")]
public partial interface PrintRequestAttribute
	: IJavaObject
	, Dova.JDK.javax.print.attribute.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static PrintRequestAttribute()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/attribute/PrintRequestAttribute;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
