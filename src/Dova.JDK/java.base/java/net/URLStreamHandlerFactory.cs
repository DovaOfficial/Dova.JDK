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

namespace Dova.JDK.java.net;

[JniSignatureAttribute("Ljava/net/URLStreamHandlerFactory;", "public abstract interface")]
public partial interface URLStreamHandlerFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static URLStreamHandlerFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/URLStreamHandlerFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createURLStreamHandler", "(Ljava/lang/String;)Ljava/net/URLStreamHandler;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/URLStreamHandler;", "public abstract")]
	Dova.JDK.java.net.URLStreamHandler createURLStreamHandler(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URLStreamHandler>(ret);
	}
}
