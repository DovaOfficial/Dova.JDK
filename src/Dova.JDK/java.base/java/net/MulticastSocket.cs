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

namespace Dova.JDK.java.net;

[JniSignatureAttribute("Ljava/net/MulticastSocket;", "public")]
public partial class MulticastSocket
	: Dova.JDK.java.net.DatagramSocket
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MulticastSocket()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/MulticastSocket;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/SocketAddress;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/MulticastSocket;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delegate_0", "()Ljava/net/DatagramSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delegate_1", "()Ljava/net/MulticastSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimeToLive", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "joinGroup", "(Ljava/net/InetAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leaveGroup", "(Ljava/net/InetAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTTL", "(B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimeToLive", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTTL", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInterface", "(Ljava/net/InetAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterface", "()Ljava/net/InetAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNetworkInterface", "(Ljava/net/NetworkInterface;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNetworkInterface", "()Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLoopbackMode", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoopbackMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "(Ljava/net/DatagramPacket;B)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MulticastSocket(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public MulticastSocket(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)V", "public")]
	public MulticastSocket(Dova.JDK.java.net.SocketAddress arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/net/MulticastSocket;)V", "")]
	public MulticastSocket(Dova.JDK.java.net.MulticastSocket arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MulticastSocket() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/net/MulticastSocket;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/net/DatagramSocket;", "volatile")]
	public Dova.JDK.java.net.DatagramSocket delegate_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.DatagramSocket>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/MulticastSocket;", "final")]
	public Dova.JDK.java.net.MulticastSocket delegate_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.MulticastSocket>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTimeToLive()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", "public")]
	public void joinGroup(Dova.JDK.java.net.SocketAddress arg0, Dova.JDK.java.net.NetworkInterface arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)V", "public")]
	public void joinGroup(Dova.JDK.java.net.InetAddress arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", "public")]
	public void leaveGroup(Dova.JDK.java.net.SocketAddress arg0, Dova.JDK.java.net.NetworkInterface arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)V", "public")]
	public void leaveGroup(Dova.JDK.java.net.InetAddress arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(B)V", "public")]
	public void setTTL(byte arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setTimeToLive(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()B", "public")]
	public byte getTTL()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)V", "public")]
	public void setInterface(Dova.JDK.java.net.InetAddress arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Ljava/net/InetAddress;", "public")]
	public Dova.JDK.java.net.InetAddress getInterface()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/NetworkInterface;)V", "public")]
	public void setNetworkInterface(Dova.JDK.java.net.NetworkInterface arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljava/net/NetworkInterface;", "public")]
	public Dova.JDK.java.net.NetworkInterface getNetworkInterface()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setLoopbackMode(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getLoopbackMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/DatagramPacket;B)V", "public")]
	public void send(Dova.JDK.java.net.DatagramPacket arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}
}
