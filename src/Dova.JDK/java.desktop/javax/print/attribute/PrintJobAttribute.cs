/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.print.attribute;

[JniSignatureAttribute("Ljavax/print/attribute/PrintJobAttribute;", "public abstract interface")]
public partial interface PrintJobAttribute
	: IJavaObject
	, Dova.JDK.javax.print.attribute.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static PrintJobAttribute()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/print/attribute/PrintJobAttribute;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}