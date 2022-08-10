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

namespace Dova.JDK.sun.nio.ch;

[JniSignatureAttribute("Lsun/nio/ch/LinuxAsynchronousChannelProvider;", "public")]
public partial class LinuxAsynchronousChannelProvider
	: Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LinuxAsynchronousChannelProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/LinuxAsynchronousChannelProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "defaultPort", "Lsun/nio/ch/EPollPort;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LinuxAsynchronousChannelProvider", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "defaultEventPort", "()Lsun/nio/ch/EPollPort;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toPort", "(Ljava/nio/channels/AsynchronousChannelGroup;)Lsun/nio/ch/Port;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openAsynchronousChannelGroup", "(Ljava/util/concurrent/ExecutorService;I)Ljava/nio/channels/AsynchronousChannelGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openAsynchronousChannelGroup", "(ILjava/util/concurrent/ThreadFactory;)Ljava/nio/channels/AsynchronousChannelGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openAsynchronousServerSocketChannel", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousServerSocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openAsynchronousSocketChannel", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousSocketChannel;"));
	}

	[JniSignatureAttribute("Lsun/nio/ch/EPollPort;", "private static volatile")]
	public static Dova.JDK.sun.nio.ch.EPollPort defaultPort_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.EPollPort>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LinuxAsynchronousChannelProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public LinuxAsynchronousChannelProvider() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/LinuxAsynchronousChannelProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/nio/ch/EPollPort;", "private")]
	public Dova.JDK.sun.nio.ch.EPollPort defaultEventPort()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.EPollPort>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/channels/AsynchronousChannelGroup;)Lsun/nio/ch/Port;", "private")]
	public Dova.JDK.sun.nio.ch.Port toPort(Dova.JDK.java.nio.channels.AsynchronousChannelGroup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.Port>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ExecutorService;I)Ljava/nio/channels/AsynchronousChannelGroup;", "public")]
	public Dova.JDK.java.nio.channels.AsynchronousChannelGroup openAsynchronousChannelGroup(Dova.JDK.java.util.concurrent.ExecutorService arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousChannelGroup>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/concurrent/ThreadFactory;)Ljava/nio/channels/AsynchronousChannelGroup;", "public")]
	public Dova.JDK.java.nio.channels.AsynchronousChannelGroup openAsynchronousChannelGroup(int arg0, Dova.JDK.java.util.concurrent.ThreadFactory arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousChannelGroup>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousServerSocketChannel;", "public")]
	public Dova.JDK.java.nio.channels.AsynchronousServerSocketChannel openAsynchronousServerSocketChannel(Dova.JDK.java.nio.channels.AsynchronousChannelGroup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousServerSocketChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousSocketChannel;", "public")]
	public Dova.JDK.java.nio.channels.AsynchronousSocketChannel openAsynchronousSocketChannel(Dova.JDK.java.nio.channels.AsynchronousChannelGroup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousSocketChannel>(ret);
	}
}
