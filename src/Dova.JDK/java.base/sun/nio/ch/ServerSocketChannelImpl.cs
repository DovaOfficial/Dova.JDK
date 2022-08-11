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

namespace Dova.JDK.sun.nio.ch;

[JniSignatureAttribute("Lsun/nio/ch/ServerSocketChannelImpl;", "")]
public partial class ServerSocketChannelImpl
	: Dova.JDK.java.nio.channels.ServerSocketChannel
	, Dova.JDK.sun.nio.ch.SelChImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ServerSocketChannelImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/ServerSocketChannelImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nd", "Lsun/nio/ch/NativeDispatcher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "family", "Ljava/net/ProtocolFamily;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fd", "Ljava/io/FileDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fdVal", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acceptLock", "Ljava/util/concurrent/locks/ReentrantLock;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stateLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ST_INUSE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ST_CLOSING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ST_CLOSED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localAddress", "Ljava/net/SocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isReuseAddress", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "socket", "Ljava/net/ServerSocket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;Ljava/net/ProtocolFamily;Ljava/io/FileDescriptor;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;Ljava/net/ProtocolFamily;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "(ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "()Ljava/nio/channels/SocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFD", "()Ljava/io/FileDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/net/SocketAddress;I)Ljava/nio/channels/ServerSocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOption_0", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/NetworkChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOption_1", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/ServerSocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "socket", "()Ljava/net/ServerSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalAddress", "()Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOption", "(Ljava/net/SocketOption;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportedOptions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localAddress", "()Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "blockingAccept", "(J)Ljava/nio/channels/SocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBound", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implAccept", "(Ljava/io/FileDescriptor;Ljava/io/FileDescriptor;[Ljava/net/SocketAddress;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNetSocket", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnixSocket", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unixBind", "(Ljava/net/SocketAddress;I)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "netBind", "(Ljava/net/SocketAddress;I)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFinishClose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishAccept", "(Ljava/io/FileDescriptor;Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lockedConfigureBlocking", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryLockedConfigureBlocking", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryClose", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implCloseBlockingMode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implCloseNonBlockingMode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateReadyOps", "(IILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implCloseSelectableChannel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implConfigureBlocking", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateInterestOps", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFDVal", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kill", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateAndSetReadyOps", "(ILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateAndUpdateReadyOps", "(ILsun/nio/ch/SelectionKeyImpl;)Z"));
	}

	[JniSignatureAttribute("Lsun/nio/ch/NativeDispatcher;", "private static final")]
	public static Dova.JDK.sun.nio.ch.NativeDispatcher nd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.NativeDispatcher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/ProtocolFamily;", "private final")]
	public Dova.JDK.java.net.ProtocolFamily family_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.ProtocolFamily>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/FileDescriptor;", "private final")]
	public Dova.JDK.java.io.FileDescriptor fd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int fdVal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/ReentrantLock;", "private final")]
	public Dova.JDK.java.util.concurrent.locks.ReentrantLock acceptLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReentrantLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object stateLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ST_INUSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ST_CLOSING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ST_CLOSED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long thread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/SocketAddress;", "private")]
	public Dova.JDK.java.net.SocketAddress localAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isReuseAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/ServerSocket;", "private")]
	public Dova.JDK.java.net.ServerSocket socket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.ServerSocket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ServerSocketChannelImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;Ljava/net/ProtocolFamily;Ljava/io/FileDescriptor;Z)V", "")]
	public ServerSocketChannelImpl(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0, Dova.JDK.java.net.ProtocolFamily arg1, Dova.JDK.java.io.FileDescriptor arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;Ljava/net/ProtocolFamily;)V", "")]
	public ServerSocketChannelImpl(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0, Dova.JDK.java.net.ProtocolFamily arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;)V", "")]
	public ServerSocketChannelImpl(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/ServerSocketChannelImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(ZZ)V", "private")]
	public void end(bool arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void begin(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/SocketChannel;", "public")]
	public Dova.JDK.java.nio.channels.SocketChannel accept()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SocketChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/FileDescriptor;", "public")]
	public Dova.JDK.java.io.FileDescriptor getFD()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;I)Ljava/nio/channels/ServerSocketChannel;", "public")]
	public Dova.JDK.java.nio.channels.ServerSocketChannel bind(Dova.JDK.java.net.SocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.ServerSocketChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/NetworkChannel;", "public volatile")]
	public Dova.JDK.java.nio.channels.NetworkChannel setOption_0(Dova.JDK.java.net.SocketOption arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.NetworkChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/ServerSocketChannel;", "public")]
	public Dova.JDK.java.nio.channels.ServerSocketChannel setOption_1(Dova.JDK.java.net.SocketOption arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.ServerSocketChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/ServerSocket;", "public")]
	public Dova.JDK.java.net.ServerSocket socket()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.ServerSocket>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "public")]
	public Dova.JDK.java.net.SocketAddress getLocalAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketOption;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getOption(Dova.JDK.java.net.SocketOption arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public final")]
	public Dova.JDK.java.util.Set supportedOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "")]
	public Dova.JDK.java.net.SocketAddress localAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/nio/channels/SocketChannel;", "")]
	public Dova.JDK.java.nio.channels.SocketChannel blockingAccept(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SocketChannel>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isBound()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/io/FileDescriptor;[Ljava/net/SocketAddress;)I", "private")]
	public int implAccept(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.io.FileDescriptor arg1, JavaArray<Dova.JDK.java.net.SocketAddress> arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isNetSocket()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isUnixSocket()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;I)Ljava/net/SocketAddress;", "private")]
	public Dova.JDK.java.net.SocketAddress unixBind(Dova.JDK.java.net.SocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;I)Ljava/net/SocketAddress;", "private")]
	public Dova.JDK.java.net.SocketAddress netBind(Dova.JDK.java.net.SocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void tryFinishClose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;", "private")]
	public Dova.JDK.java.nio.channels.SocketChannel finishAccept(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.net.SocketAddress arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SocketChannel>(ret);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void lockedConfigureBlocking(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Z)Z", "private")]
	public bool tryLockedConfigureBlocking(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool tryClose()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void implCloseBlockingMode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void implCloseNonBlockingMode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("(IILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateReadyOps(int arg0, int arg1, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void implCloseSelectableChannel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29]);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void implConfigureBlocking(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int translateInterestOps(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getFDVal()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void kill()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33]);
	}

	[JniSignatureAttribute("(ILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateAndSetReadyOps(int arg0, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateAndUpdateReadyOps(int arg0, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Lsun/nio/ch/ServerSocketChannelImpl$DefaultOptionsHolder;", "private static")]
	public partial class DefaultOptionsHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultOptionsHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/ServerSocketChannelImpl$DefaultOptionsHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultInetOptions", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultUnixDomainOptions", "Ljava/util/Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "defaultUnixDomainOptions", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "defaultInetOptions", "()Ljava/util/Set;"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "static final")]
		public static Dova.JDK.java.util.Set defaultInetOptions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "static final")]
		public static Dova.JDK.java.util.Set defaultUnixDomainOptions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultOptionsHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DefaultOptionsHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/ServerSocketChannelImpl$DefaultOptionsHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Set;", "private static")]
		public static Dova.JDK.java.util.Set defaultUnixDomainOptions()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "private static")]
		public static Dova.JDK.java.util.Set defaultInetOptions()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
	}
}
