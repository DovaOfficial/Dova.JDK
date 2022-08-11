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

namespace Dova.JDK.javax.naming.spi;

[JniSignatureAttribute("Ljavax/naming/spi/ObjectFactoryBuilder;", "public abstract interface")]
public partial interface ObjectFactoryBuilder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ObjectFactoryBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/spi/ObjectFactoryBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createObjectFactory", "(Ljava/lang/Object;Ljava/util/Hashtable;)Ljavax/naming/spi/ObjectFactory;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Hashtable;)Ljavax/naming/spi/ObjectFactory;", "public abstract")]
	Dova.JDK.javax.naming.spi.ObjectFactory createObjectFactory(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Hashtable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.spi.ObjectFactory>(ret);
	}
}
