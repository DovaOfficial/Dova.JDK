/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.nio.sctp;

[JniSignatureAttribute("Lcom/sun/nio/sctp/SctpChannel;", "public abstract")]
public partial class SctpChannel
	: Dova.JDK.java.nio.channels.spi.AbstractSelectableChannel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SctpChannel()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/nio/sctp/SctpChannel;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SctpChannel", "(Ljava/nio/channels/spi/SelectorProvider;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "shutdown", "()Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "connect", "(Ljava/net/SocketAddress;II)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "connect", "(Ljava/net/SocketAddress;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "open", "()Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "open", "(Ljava/net/SocketAddress;II)Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "bind", "(Ljava/net/SocketAddress;)Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "finishConnect", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "send", "(Ljava/nio/ByteBuffer;Lcom/sun/nio/sctp/MessageInfo;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "validOps", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isConnectionPending", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "association", "()Lcom/sun/nio/sctp/Association;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "receive", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Lcom/sun/nio/sctp/NotificationHandler;)Lcom/sun/nio/sctp/MessageInfo;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getRemoteAddresses", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "unbindAddress", "(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAllLocalAddresses", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "bindAddress", "(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOption", "(Lcom/sun/nio/sctp/SctpSocketOption;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setOption", "(Lcom/sun/nio/sctp/SctpSocketOption;Ljava/lang/Object;)Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "supportedOptions", "()Ljava/util/Set;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SctpChannel(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;)V", "protected")]
	public SctpChannel(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/sctp/SctpChannel;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/SctpChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpChannel shutdown()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;II)Z", "public abstract")]
	public bool connect(Dova.JDK.java.net.SocketAddress arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Z", "public abstract")]
	public bool connect(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/SctpChannel;", "public static")]
	public static Dova.JDK.com.sun.nio.sctp.SctpChannel open()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;II)Lcom/sun/nio/sctp/SctpChannel;", "public static")]
	public static Dova.JDK.com.sun.nio.sctp.SctpChannel open(Dova.JDK.java.net.SocketAddress arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Lcom/sun/nio/sctp/SctpChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpChannel bind(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool finishConnect()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Lcom/sun/nio/sctp/MessageInfo;)I", "public abstract")]
	public int send(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.com.sun.nio.sctp.MessageInfo arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int validOps()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isConnectionPending()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/Association;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.Association association()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.Association>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Lcom/sun/nio/sctp/NotificationHandler;)Lcom/sun/nio/sctp/MessageInfo;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.MessageInfo receive(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.com.sun.nio.sctp.NotificationHandler arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.MessageInfo>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	public Dova.JDK.java.util.Set getRemoteAddresses()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpChannel unbindAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	public Dova.JDK.java.util.Set getAllLocalAddresses()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpChannel bindAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/SctpSocketOption;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object getOption(Dova.JDK.com.sun.nio.sctp.SctpSocketOption arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/SctpSocketOption;Ljava/lang/Object;)Lcom/sun/nio/sctp/SctpChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpChannel setOption(Dova.JDK.com.sun.nio.sctp.SctpSocketOption arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	public Dova.JDK.java.util.Set supportedOptions()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}
}
