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

namespace Dova.JDK.sun.text.resources;

[JniSignatureAttribute("Lsun/text/resources/CollationDataProvider;", "public abstract interface")]
public partial interface CollationDataProvider
	: IJavaObject
	, Dova.JDK.java.util.spi.ResourceBundleProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static CollationDataProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/text/resources/CollationDataProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
