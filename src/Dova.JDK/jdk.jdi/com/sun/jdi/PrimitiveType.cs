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

namespace Dova.JDK.com.sun.jdi;

[JniSignatureAttribute("Lcom/sun/jdi/PrimitiveType;", "public abstract interface")]
public partial interface PrimitiveType
	: IJavaObject
	, Dova.JDK.com.sun.jdi.Type
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static PrimitiveType()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/jdi/PrimitiveType;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}
