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

namespace Dova.JDK.java.nio.channels;

[JniSignatureAttribute("Ljava/nio/channels/MulticastChannel;", "public abstract interface")]
public partial interface MulticastChannel
	: IJavaObject
	, Dova.JDK.java.nio.channels.NetworkChannel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MulticastChannel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/MulticastChannel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "join", "(Ljava/net/InetAddress;Ljava/net/NetworkInterface;)Ljava/nio/channels/MembershipKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "join", "(Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;)Ljava/nio/channels/MembershipKey;", "public abstract")]
	Dova.JDK.java.nio.channels.MembershipKey join(Dova.JDK.java.net.InetAddress arg0, Dova.JDK.java.net.NetworkInterface arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MembershipKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", "public abstract")]
	Dova.JDK.java.nio.channels.MembershipKey join(Dova.JDK.java.net.InetAddress arg0, Dova.JDK.java.net.NetworkInterface arg1, Dova.JDK.java.net.InetAddress arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MembershipKey>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}
}
