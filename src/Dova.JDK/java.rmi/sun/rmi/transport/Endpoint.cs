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

namespace Dova.JDK.sun.rmi.transport;

[JniSignatureAttribute("Lsun/rmi/transport/Endpoint;", "public abstract interface")]
public partial interface Endpoint
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Endpoint()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/transport/Endpoint;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getChannel", "()Lsun/rmi/transport/Channel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInboundTransport", "()Lsun/rmi/transport/Transport;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOutboundTransport", "()Lsun/rmi/transport/Transport;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "exportObject", "(Lsun/rmi/transport/Target;)V"));
	}

	[JniSignatureAttribute("()Lsun/rmi/transport/Channel;", "public abstract")]
	Dova.JDK.sun.rmi.transport.Channel getChannel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Channel>(ret);
	}

	[JniSignatureAttribute("()Lsun/rmi/transport/Transport;", "public abstract")]
	Dova.JDK.sun.rmi.transport.Transport getInboundTransport()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Transport>(ret);
	}

	[JniSignatureAttribute("()Lsun/rmi/transport/Transport;", "public abstract")]
	Dova.JDK.sun.rmi.transport.Transport getOutboundTransport()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Transport>(ret);
	}

	[JniSignatureAttribute("(Lsun/rmi/transport/Target;)V", "public abstract")]
	void exportObject(Dova.JDK.sun.rmi.transport.Target arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}
}
