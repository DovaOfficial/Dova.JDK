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

[JniSignatureAttribute("Lcom/sun/jdi/FloatType;", "public abstract interface")]
public partial interface FloatType
	: IJavaObject
	, Dova.JDK.com.sun.jdi.PrimitiveType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static FloatType()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/jdi/FloatType;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}