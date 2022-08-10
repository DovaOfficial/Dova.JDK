/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.naming.spi;

[JniSignatureAttribute("Ljavax/naming/spi/InitialContextFactoryBuilder;", "public abstract interface")]
public partial interface InitialContextFactoryBuilder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InitialContextFactoryBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/spi/InitialContextFactoryBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createInitialContextFactory", "(Ljava/util/Hashtable;)Ljavax/naming/spi/InitialContextFactory;"));
	}

	[JniSignatureAttribute("(Ljava/util/Hashtable;)Ljavax/naming/spi/InitialContextFactory;", "public abstract")]
	Dova.JDK.javax.naming.spi.InitialContextFactory createInitialContextFactory(Dova.JDK.java.util.Hashtable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.spi.InitialContextFactory>(ret);
	}
}
