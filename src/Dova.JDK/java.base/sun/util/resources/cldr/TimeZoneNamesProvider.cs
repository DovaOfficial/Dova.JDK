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

namespace Dova.JDK.sun.util.resources.cldr;

[JniSignatureAttribute("Lsun/util/resources/cldr/TimeZoneNamesProvider;", "public abstract interface")]
public partial interface TimeZoneNamesProvider
	: IJavaObject
	, Dova.JDK.java.util.spi.ResourceBundleProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static TimeZoneNamesProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/resources/cldr/TimeZoneNamesProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
