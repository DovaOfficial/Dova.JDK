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

[JniSignatureAttribute("Ljava/nio/channels/DatagramChannel;", "public abstract")]
public partial class DatagramChannel
	: Dova.JDK.java.nio.channels.spi.AbstractSelectableChannel
	, Dova.JDK.java.nio.channels.ByteChannel
	, Dova.JDK.java.nio.channels.ScatteringByteChannel
	, Dova.JDK.java.nio.channels.GatheringByteChannel
	, Dova.JDK.java.nio.channels.MulticastChannel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DatagramChannel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/DatagramChannel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "([Ljava/nio/ByteBuffer;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "([Ljava/nio/ByteBuffer;II)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([Ljava/nio/ByteBuffer;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([Ljava/nio/ByteBuffer;II)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "open", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "open", "()Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind_0", "(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind_1", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConnected", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disconnect", "()Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "socket", "()Ljava/net/DatagramSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalAddress", "()Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRemoteAddress", "()Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOption_0", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOption_1", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/NetworkChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validOps", "()I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DatagramChannel(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;)V", "protected")]
	public DatagramChannel(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/channels/DatagramChannel;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;)J", "public final")]
	public long write(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)I", "public abstract")]
	public int write(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)J", "public abstract")]
	public long write(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;)J", "public final")]
	public long read(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)I", "public abstract")]
	public int read(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)J", "public abstract")]
	public long read(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.DatagramChannel connect(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;", "public static")]
	public static Dova.JDK.java.nio.channels.DatagramChannel open(Dova.JDK.java.net.ProtocolFamily arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/DatagramChannel;", "public static")]
	public static Dova.JDK.java.nio.channels.DatagramChannel open()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;", "public volatile")]
	public Dova.JDK.java.nio.channels.NetworkChannel bind_0(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.NetworkChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.DatagramChannel bind_1(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isConnected()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/channels/DatagramChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.DatagramChannel disconnect()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/DatagramSocket;", "public abstract")]
	public Dova.JDK.java.net.DatagramSocket socket()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.DatagramSocket>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "public abstract")]
	public Dova.JDK.java.net.SocketAddress getLocalAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I", "public abstract")]
	public int send(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.net.SocketAddress arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", "public abstract")]
	public Dova.JDK.java.net.SocketAddress receive(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "public abstract")]
	public Dova.JDK.java.net.SocketAddress getRemoteAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/DatagramChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.DatagramChannel setOption_0(Dova.JDK.java.net.SocketOption arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/NetworkChannel;", "public volatile")]
	public Dova.JDK.java.nio.channels.NetworkChannel setOption_1(Dova.JDK.java.net.SocketOption arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.NetworkChannel>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int validOps()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}
}
