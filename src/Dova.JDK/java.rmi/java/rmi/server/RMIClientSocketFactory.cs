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

namespace Dova.JDK.java.rmi.server;

[JniSignatureAttribute("Ljava/rmi/server/RMIClientSocketFactory;", "public abstract interface")]
public partial interface RMIClientSocketFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RMIClientSocketFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/rmi/server/RMIClientSocketFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/net/Socket;", "public abstract")]
	Dova.JDK.java.net.Socket createSocket(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
	}
}
