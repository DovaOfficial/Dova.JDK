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

namespace Dova.JDK.sun.util.resources;

[JniSignatureAttribute("Lsun/util/resources/LocaleDataProvider;", "public abstract interface")]
public partial interface LocaleDataProvider
	: IJavaObject
	, Dova.JDK.java.util.spi.ResourceBundleProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static LocaleDataProvider()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/util/resources/LocaleDataProvider;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}
