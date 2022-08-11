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

[JniSignatureAttribute("Lsun/nio/ch/DatagramChannelImpl;", "")]
public partial class DatagramChannelImpl
	: Dova.JDK.java.nio.channels.DatagramChannel
	, Dova.JDK.sun.nio.ch.SelChImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DatagramChannelImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/DatagramChannelImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nd", "Lsun/nio/ch/NativeDispatcher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interruptible", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "family", "Ljava/net/ProtocolFamily;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fd", "Ljava/io/FileDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fdVal", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceSockAddr", "Lsun/nio/ch/NativeSocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedSockAddr", "Lsun/nio/ch/NativeSocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedInetSocketAddress", "Ljava/net/InetSocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetSockAddr", "Lsun/nio/ch/NativeSocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousTarget", "Ljava/net/InetSocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousSockAddrLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cleaner", "Ljava/lang/ref/Cleaner$Cleanable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readLock", "Ljava/util/concurrent/locks/ReentrantLock;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeLock", "Ljava/util/concurrent/locks/ReentrantLock;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stateLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ST_UNCONNECTED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ST_CONNECTED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ST_CLOSING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ST_CLOSED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerThread", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writerThread", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localAddress", "Ljava/net/InetSocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "remoteAddress", "Ljava/net/InetSocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialLocalAddress", "Ljava/net/InetSocketAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOCKET", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "socket", "Ljava/net/DatagramSocket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registry", "Lsun/nio/ch/MembershipRegistry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reuseAddressEmulated", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isReuseAddress", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;Ljava/io/FileDescriptor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;Ljava/net/ProtocolFamily;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "join", "(Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "join", "(Ljava/net/InetAddress;Ljava/net/NetworkInterface;)Ljava/nio/channels/MembershipKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "([Ljava/nio/ByteBuffer;II)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Ljava/nio/ByteBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "([Ljava/nio/ByteBuffer;II)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "(Ljava/net/SocketAddress;Z)Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "block", "(Lsun/nio/ch/MembershipKeyImpl;Ljava/net/InetAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFD", "()Ljava/io/FileDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind_0", "(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind_1", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConnected", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disconnect", "()Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "socket", "()Ljava/net/DatagramSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remoteAddress", "()Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drop", "(Lsun/nio/ch/MembershipKeyImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localAddress", "()Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalAddress", "()Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;Ljava/net/InetSocketAddress;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receive", "(Ljava/nio/ByteBuffer;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kill", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOption", "(Ljava/net/SocketOption;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportedOptions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryFinishClose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginRead", "(ZZ)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endRead", "(ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beginWrite", "(ZZ)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endWrite", "(ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryClose", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerJoin", "(Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implCloseBlockingMode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implCloseNonBlockingMode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateReadyOps", "(IILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "blockingReceive", "(Ljava/nio/ByteBuffer;J)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "blockingSend", "(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findMembership", "(Ljava/net/InetAddress;Ljava/net/NetworkInterface;)Ljava/nio/channels/MembershipKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unblock", "(Lsun/nio/ch/MembershipKeyImpl;Ljava/net/InetAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateAndUpdateReadyOps", "(ILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateAndSetReadyOps", "(ILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateInterestOps", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFDVal", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "releaserFor", "(Ljava/io/FileDescriptor;[Lsun/nio/ch/NativeSocketAddress;)Ljava/lang/Runnable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "familyFor", "(Ljava/net/SocketOption;)Ljava/net/ProtocolFamily;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bindInternal", "(Ljava/net/SocketAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sourceSocketAddress", "()Ljava/net/InetSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "untrustedReceive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trustedBlockingReceive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trustedBlockingReceive", "(Ljava/nio/ByteBuffer;J)Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lockedConfigureBlocking", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryLockedConfigureBlocking", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiveIntoNativeBuffer", "(Ljava/nio/ByteBuffer;IIZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "receive0", "(Ljava/io/FileDescriptor;JIJZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendFromNativeBuffer", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;Ljava/net/InetSocketAddress;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "targetSocketAddress", "(Ljava/net/InetSocketAddress;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "send0", "(Ljava/io/FileDescriptor;JIJI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "disconnect0", "(Ljava/io/FileDescriptor;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repairSocket", "(Ljava/net/InetSocketAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRemoteAddress", "()Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implCloseSelectableChannel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implConfigureBlocking", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOption_0", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOption_1", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/NetworkChannel;"));
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

	[JniSignatureAttribute("Z", "private final")]
	public bool interruptible_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/ProtocolFamily;", "private final")]
	public Dova.JDK.java.net.ProtocolFamily family_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.ProtocolFamily>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/FileDescriptor;", "private final")]
	public Dova.JDK.java.io.FileDescriptor fd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int fdVal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/NativeSocketAddress;", "private")]
	public Dova.JDK.sun.nio.ch.NativeSocketAddress sourceSockAddr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.NativeSocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/NativeSocketAddress;", "private")]
	public Dova.JDK.sun.nio.ch.NativeSocketAddress cachedSockAddr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.NativeSocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/InetSocketAddress;", "private")]
	public Dova.JDK.java.net.InetSocketAddress cachedInetSocketAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/NativeSocketAddress;", "private final")]
	public Dova.JDK.sun.nio.ch.NativeSocketAddress targetSockAddr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.NativeSocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/InetSocketAddress;", "private")]
	public Dova.JDK.java.net.InetSocketAddress previousTarget_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int previousSockAddrLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/Cleaner$Cleanable;", "private final")]
	public Dova.JDK.java.lang.@ref.Cleaner.Cleanable cleaner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.Cleaner.Cleanable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/ReentrantLock;", "private final")]
	public Dova.JDK.java.util.concurrent.locks.ReentrantLock readLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReentrantLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/ReentrantLock;", "private final")]
	public Dova.JDK.java.util.concurrent.locks.ReentrantLock writeLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReentrantLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object stateLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ST_UNCONNECTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ST_CONNECTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ST_CLOSING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ST_CLOSED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long readerThread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long writerThread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/InetSocketAddress;", "private")]
	public Dova.JDK.java.net.InetSocketAddress localAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/InetSocketAddress;", "private")]
	public Dova.JDK.java.net.InetSocketAddress remoteAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/InetSocketAddress;", "private")]
	public Dova.JDK.java.net.InetSocketAddress initialLocalAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle SOCKET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/DatagramSocket;", "private volatile")]
	public Dova.JDK.java.net.DatagramSocket socket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.DatagramSocket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/MembershipRegistry;", "private")]
	public Dova.JDK.sun.nio.ch.MembershipRegistry registry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.MembershipRegistry>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool reuseAddressEmulated_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isReuseAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DatagramChannelImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;Ljava/io/FileDescriptor;)V", "")]
	public DatagramChannelImpl(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0, Dova.JDK.java.io.FileDescriptor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;Ljava/net/ProtocolFamily;Z)V", "")]
	public DatagramChannelImpl(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0, Dova.JDK.java.net.ProtocolFamily arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;Z)V", "")]
	public DatagramChannelImpl(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/DatagramChannelImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", "public")]
	public Dova.JDK.java.nio.channels.MembershipKey join(Dova.JDK.java.net.InetAddress arg0, Dova.JDK.java.net.NetworkInterface arg1, Dova.JDK.java.net.InetAddress arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MembershipKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;)Ljava/nio/channels/MembershipKey;", "public")]
	public Dova.JDK.java.nio.channels.MembershipKey join(Dova.JDK.java.net.InetAddress arg0, Dova.JDK.java.net.NetworkInterface arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MembershipKey>(ret);
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)J", "public")]
	public long write(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)I", "public")]
	public int write(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)I", "public")]
	public int read(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)J", "public")]
	public long read(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", "public")]
	public Dova.JDK.java.nio.channels.DatagramChannel connect(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;Z)Ljava/nio/channels/DatagramChannel;", "")]
	public Dova.JDK.java.nio.channels.DatagramChannel connect(Dova.JDK.java.net.SocketAddress arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/ch/MembershipKeyImpl;Ljava/net/InetAddress;)V", "")]
	public void block(Dova.JDK.sun.nio.ch.MembershipKeyImpl arg0, Dova.JDK.java.net.InetAddress arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/io/FileDescriptor;", "public")]
	public Dova.JDK.java.io.FileDescriptor getFD()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;", "public volatile")]
	public Dova.JDK.java.nio.channels.NetworkChannel bind_0(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.NetworkChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", "public")]
	public Dova.JDK.java.nio.channels.DatagramChannel bind_1(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isConnected()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/channels/DatagramChannel;", "public")]
	public Dova.JDK.java.nio.channels.DatagramChannel disconnect()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/DatagramSocket;", "public")]
	public Dova.JDK.java.net.DatagramSocket socket()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.DatagramSocket>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/InetSocketAddress;", "")]
	public Dova.JDK.java.net.InetSocketAddress remoteAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/ch/MembershipKeyImpl;)V", "")]
	public void drop(Dova.JDK.sun.nio.ch.MembershipKeyImpl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljava/net/InetSocketAddress;", "")]
	public Dova.JDK.java.net.InetSocketAddress localAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "public")]
	public Dova.JDK.java.net.SocketAddress getLocalAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;Ljava/net/InetSocketAddress;)I", "private")]
	public int send(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.java.net.InetSocketAddress arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)I", "public")]
	public int send(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.net.SocketAddress arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", "public")]
	public Dova.JDK.java.net.SocketAddress receive(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Z)I", "private")]
	public int receive(Dova.JDK.java.nio.ByteBuffer arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void kill()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}

	[JniSignatureAttribute("(Ljava/net/SocketOption;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getOption(Dova.JDK.java.net.SocketOption arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public final")]
	public Dova.JDK.java.util.Set supportedOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void tryFinishClose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("(ZZ)Ljava/net/SocketAddress;", "private")]
	public Dova.JDK.java.net.SocketAddress beginRead(bool arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(ZZ)V", "private")]
	public void endRead(bool arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("(ZZ)Ljava/net/SocketAddress;", "private")]
	public Dova.JDK.java.net.SocketAddress beginWrite(bool arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(ZZ)V", "private")]
	public void endWrite(bool arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool tryClose()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", "private")]
	public Dova.JDK.java.nio.channels.MembershipKey innerJoin(Dova.JDK.java.net.InetAddress arg0, Dova.JDK.java.net.NetworkInterface arg1, Dova.JDK.java.net.InetAddress arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MembershipKey>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void implCloseBlockingMode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void implCloseNonBlockingMode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35]);
	}

	[JniSignatureAttribute("(IILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateReadyOps(int arg0, int arg1, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;J)Ljava/net/SocketAddress;", "")]
	public Dova.JDK.java.net.SocketAddress blockingReceive(Dova.JDK.java.nio.ByteBuffer arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/net/SocketAddress;)V", "")]
	public void blockingSend(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.net.SocketAddress arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;Ljava/net/NetworkInterface;)Ljava/nio/channels/MembershipKey;", "")]
	public Dova.JDK.java.nio.channels.MembershipKey findMembership(Dova.JDK.java.net.InetAddress arg0, Dova.JDK.java.net.NetworkInterface arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MembershipKey>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/ch/MembershipKeyImpl;Ljava/net/InetAddress;)V", "")]
	public void unblock(Dova.JDK.sun.nio.ch.MembershipKeyImpl arg0, Dova.JDK.java.net.InetAddress arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
	}

	[JniSignatureAttribute("(ILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateAndUpdateReadyOps(int arg0, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateAndSetReadyOps(int arg0, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int translateInterestOps(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getFDVal()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[44]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Lsun/nio/ch/NativeSocketAddress;)Ljava/lang/Runnable;", "private static transient")]
	public static Dova.JDK.java.lang.Runnable releaserFor(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.sun.nio.ch.NativeSocketAddress> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketOption;)Ljava/net/ProtocolFamily;", "private")]
	public Dova.JDK.java.net.ProtocolFamily familyFor(Dova.JDK.java.net.SocketOption arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.ProtocolFamily>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)V", "private")]
	public void bindInternal(Dova.JDK.java.net.SocketAddress arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("()Ljava/net/InetSocketAddress;", "private")]
	public Dova.JDK.java.net.InetSocketAddress sourceSocketAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetSocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", "private")]
	public Dova.JDK.java.net.SocketAddress untrustedReceive(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", "private")]
	public Dova.JDK.java.net.SocketAddress trustedBlockingReceive(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;J)Ljava/net/SocketAddress;", "private")]
	public Dova.JDK.java.net.SocketAddress trustedBlockingReceive(Dova.JDK.java.nio.ByteBuffer arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void lockedConfigureBlocking(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("(Z)Z", "private")]
	public bool tryLockedConfigureBlocking(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;IIZ)I", "private")]
	public int receiveIntoNativeBuffer(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;JIJZ)I", "private static native")]
	public static int receive0(Dova.JDK.java.io.FileDescriptor arg0, long arg1, int arg2, long arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;Ljava/net/InetSocketAddress;)I", "private")]
	public int sendFromNativeBuffer(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.java.net.InetSocketAddress arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;)I", "private")]
	public int targetSocketAddress(Dova.JDK.java.net.InetSocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;JIJI)I", "private static native")]
	public static int send0(Dova.JDK.java.io.FileDescriptor arg0, long arg1, int arg2, long arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Z)V", "private static native")]
	public static void disconnect0(Dova.JDK.java.io.FileDescriptor arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/InetSocketAddress;)V", "private")]
	public void repairSocket(Dova.JDK.java.net.InetSocketAddress arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "public")]
	public Dova.JDK.java.net.SocketAddress getRemoteAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void implCloseSelectableChannel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62]);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void implConfigureBlocking(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/DatagramChannel;", "public")]
	public Dova.JDK.java.nio.channels.DatagramChannel setOption_0(Dova.JDK.java.net.SocketOption arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/NetworkChannel;", "public volatile")]
	public Dova.JDK.java.nio.channels.NetworkChannel setOption_1(Dova.JDK.java.net.SocketOption arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.NetworkChannel>(ret);
	}

	[JniSignatureAttribute("Lsun/nio/ch/DatagramChannelImpl$DefaultOptionsHolder;", "private static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/DatagramChannelImpl$DefaultOptionsHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultOptions", "Ljava/util/Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "defaultOptions", "()Ljava/util/Set;"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "static final")]
		public static Dova.JDK.java.util.Set defaultOptions_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultOptionsHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DefaultOptionsHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/DatagramChannelImpl$DefaultOptionsHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Set;", "private static")]
		public static Dova.JDK.java.util.Set defaultOptions()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/DatagramChannelImpl$AbstractSelectableChannels;", "private static")]
	public partial class AbstractSelectableChannels
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractSelectableChannels()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/DatagramChannelImpl$AbstractSelectableChannels;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOREACH", "Ljava/lang/reflect/Method;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forEach", "(Ljava/nio/channels/spi/AbstractSelectableChannel;Ljava/util/function/Consumer;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
		public static Dova.JDK.java.lang.reflect.Method FOREACH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractSelectableChannels(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AbstractSelectableChannels() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/DatagramChannelImpl$AbstractSelectableChannels;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/nio/channels/spi/AbstractSelectableChannel;Ljava/util/function/Consumer;)V", "static")]
		public static void forEach(Dova.JDK.java.nio.channels.spi.AbstractSelectableChannel arg0, Dova.JDK.java.util.function.Consumer arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}
}
