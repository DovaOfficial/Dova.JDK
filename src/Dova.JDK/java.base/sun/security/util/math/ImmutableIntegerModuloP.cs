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

namespace Dova.JDK.sun.security.util.math;

[JniSignatureAttribute("Lsun/security/util/math/ImmutableIntegerModuloP;", "public abstract interface")]
public partial interface ImmutableIntegerModuloP
	: IJavaObject
	, Dova.JDK.sun.security.util.math.IntegerModuloP
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static ImmutableIntegerModuloP()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/util/math/ImmutableIntegerModuloP;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}
