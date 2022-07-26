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

namespace Dova.JDK.com.sun.nio.sctp;

[JniSignatureAttribute("Lcom/sun/nio/sctp/SctpServerChannel;", "public abstract")]
public partial class SctpServerChannel
	: Dova.JDK.java.nio.channels.spi.AbstractSelectableChannel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SctpServerChannel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/sctp/SctpServerChannel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "()Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "open", "()Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/net/SocketAddress;)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validOps", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unbindAddress", "(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllLocalAddresses", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bindAddress", "(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOption", "(Lcom/sun/nio/sctp/SctpSocketOption;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOption", "(Lcom/sun/nio/sctp/SctpSocketOption;Ljava/lang/Object;)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportedOptions", "()Ljava/util/Set;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SctpServerChannel(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;)V", "protected")]
	public SctpServerChannel(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/sctp/SctpServerChannel;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/SctpChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpChannel accept()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/SctpServerChannel;", "public static")]
	public static Dova.JDK.com.sun.nio.sctp.SctpServerChannel open()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/SctpServerChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel bind(Dova.JDK.java.net.SocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Lcom/sun/nio/sctp/SctpServerChannel;", "public final")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel bind(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int validOps()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpServerChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel unbindAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	public Dova.JDK.java.util.Set getAllLocalAddresses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpServerChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel bindAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/SctpSocketOption;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object getOption(Dova.JDK.com.sun.nio.sctp.SctpSocketOption arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/SctpSocketOption;Ljava/lang/Object;)Lcom/sun/nio/sctp/SctpServerChannel;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel setOption(Dova.JDK.com.sun.nio.sctp.SctpSocketOption arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	public Dova.JDK.java.util.Set supportedOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}
}
