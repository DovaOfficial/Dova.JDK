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

namespace Dova.JDK.sun.nio.ch.sctp;

[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl;", "public")]
public partial class SctpMultiChannelImpl
	: Dova.JDK.com.sun.nio.sctp.SctpMultiChannel
	, Dova.JDK.sun.nio.ch.SelChImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SctpMultiChannelImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/sctp/SctpMultiChannelImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fd", "Ljava/io/FileDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fdVal", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "receiverThread", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "senderThread", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "receiveLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sendLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "stateLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "state", "Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "port", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "localAddresses", "Ljava/util/HashSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "wildcard", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "addressMap", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "associationMap", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "associationToRemove", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "receiveInvoked", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "internalNotificationHandler", "Lsun/nio/ch/sctp/SctpMultiChannelImpl$InternalNotificationHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SctpMultiChannelImpl", "(Ljava/nio/channels/spi/SelectorProvider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "shutdown", "(Lcom/sun/nio/sctp/Association;)Lcom/sun/nio/sctp/SctpMultiChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFD", "()Ljava/io/FileDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bind", "(Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/SctpMultiChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "branch", "(Lcom/sun/nio/sctp/Association;)Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "kill", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "send", "(ILjava/nio/ByteBuffer;ILjava/net/SocketAddress;Lcom/sun/nio/sctp/MessageInfo;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "send", "(Ljava/nio/ByteBuffer;Lcom/sun/nio/sctp/MessageInfo;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "implCloseSelectableChannel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "implConfigureBlocking", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "associations", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "receive", "(ILjava/nio/ByteBuffer;Lsun/nio/ch/sctp/ResultContainer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "receive", "(Ljava/nio/ByteBuffer;Ljava/lang/Object;Lcom/sun/nio/sctp/NotificationHandler;)Lcom/sun/nio/sctp/MessageInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindUnbindAddress", "(Ljava/net/InetAddress;Z)Lcom/sun/nio/sctp/SctpMultiChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "receiverCleanup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRemoteAddresses", "(Lcom/sun/nio/sctp/Association;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleNotificationInternal", "(Lsun/nio/ch/sctp/ResultContainer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "invokeNotificationHandler", "(Lsun/nio/ch/sctp/ResultContainer;Lcom/sun/nio/sctp/NotificationHandler;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "receiveIntoNativeBuffer", "(ILsun/nio/ch/sctp/ResultContainer;Ljava/nio/ByteBuffer;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "receive0", "(ILsun/nio/ch/sctp/ResultContainer;JI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkAssociation", "(Lcom/sun/nio/sctp/Association;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkStreamNumber", "(Lcom/sun/nio/sctp/Association;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "senderCleanup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sendFromNativeBuffer", "(ILjava/nio/ByteBuffer;Ljava/net/SocketAddress;IIZI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "send0", "(IJILjava/net/InetAddress;IIIZI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unbindAddress", "(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpMultiChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAllLocalAddresses", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lookupAssociation", "(I)Lcom/sun/nio/sctp/Association;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeAssociation", "(Lcom/sun/nio/sctp/Association;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addAssociation", "(Lcom/sun/nio/sctp/Association;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindAddress", "(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpMultiChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "translateReadyOps", "(IILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFDVal", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "translateAndUpdateReadyOps", "(ILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "translateAndSetReadyOps", "(ILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "translateInterestOps", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isBound", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOption", "(Lcom/sun/nio/sctp/SctpSocketOption;Lcom/sun/nio/sctp/Association;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setOption", "(Lcom/sun/nio/sctp/SctpSocketOption;Ljava/lang/Object;Lcom/sun/nio/sctp/Association;)Lcom/sun/nio/sctp/SctpMultiChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "supportedOptions", "()Ljava/util/Set;"));
	}

	[JniSignatureAttribute("Ljava/io/FileDescriptor;", "private final")]
	public Dova.JDK.java.io.FileDescriptor fd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private final")]
	public int fdVal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("J", "private volatile")]
	public long receiverThread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("J", "private volatile")]
	public long senderThread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object receiveLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object sendLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object stateLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;", "private")]
	public Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "")]
	public int port_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("Ljava/util/HashSet;", "private")]
	public Dova.JDK.java.util.HashSet localAddresses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashSet>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool wildcard_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private")]
	public Dova.JDK.java.util.HashMap addressMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private")]
	public Dova.JDK.java.util.HashMap associationMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private final")]
	public Dova.JDK.java.lang.ThreadLocal associationToRemove_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private final")]
	public Dova.JDK.java.lang.ThreadLocal receiveInvoked_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl$InternalNotificationHandler;", "private")]
	public Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.InternalNotificationHandler internalNotificationHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.InternalNotificationHandler>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[16], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SctpMultiChannelImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;)V", "public")]
	public SctpMultiChannelImpl(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/sctp/SctpMultiChannelImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Association;)Lcom/sun/nio/sctp/SctpMultiChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpMultiChannel shutdown(Dova.JDK.com.sun.nio.sctp.Association arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpMultiChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/FileDescriptor;", "public")]
	public Dova.JDK.java.io.FileDescriptor getFD()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/SctpMultiChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpMultiChannel bind(Dova.JDK.java.net.SocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpMultiChannel>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Association;)Lcom/sun/nio/sctp/SctpChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpChannel branch(Dova.JDK.com.sun.nio.sctp.Association arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void kill()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;ILjava/net/SocketAddress;Lcom/sun/nio/sctp/MessageInfo;)I", "private")]
	public int send(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, int arg2, Dova.JDK.java.net.SocketAddress arg3, Dova.JDK.com.sun.nio.sctp.MessageInfo arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Lcom/sun/nio/sctp/MessageInfo;)I", "public")]
	public int send(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.com.sun.nio.sctp.MessageInfo arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void implCloseSelectableChannel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void implConfigureBlocking(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set associations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Lsun/nio/ch/sctp/ResultContainer;)I", "private")]
	public int receive(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.sun.nio.ch.sctp.ResultContainer arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Object;Lcom/sun/nio/sctp/NotificationHandler;)Lcom/sun/nio/sctp/MessageInfo;", "public")]
	public Dova.JDK.com.sun.nio.sctp.MessageInfo receive(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.com.sun.nio.sctp.NotificationHandler arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.MessageInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;Z)Lcom/sun/nio/sctp/SctpMultiChannel;", "private")]
	public Dova.JDK.com.sun.nio.sctp.SctpMultiChannel bindUnbindAddress(Dova.JDK.java.net.InetAddress arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpMultiChannel>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void receiverCleanup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Association;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getRemoteAddresses(Dova.JDK.com.sun.nio.sctp.Association arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/ch/sctp/ResultContainer;)V", "private")]
	public void handleNotificationInternal(Dova.JDK.sun.nio.ch.sctp.ResultContainer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lsun/nio/ch/sctp/ResultContainer;Lcom/sun/nio/sctp/NotificationHandler;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;", "private")]
	public Dova.JDK.com.sun.nio.sctp.HandlerResult invokeNotificationHandler(Dova.JDK.sun.nio.ch.sctp.ResultContainer arg0, Dova.JDK.com.sun.nio.sctp.NotificationHandler arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.HandlerResult>(ret);
	}

	[JniSignatureAttribute("(ILsun/nio/ch/sctp/ResultContainer;Ljava/nio/ByteBuffer;II)I", "private")]
	public int receiveIntoNativeBuffer(int arg0, Dova.JDK.sun.nio.ch.sctp.ResultContainer arg1, Dova.JDK.java.nio.ByteBuffer arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/nio/ch/sctp/ResultContainer;JI)I", "private static")]
	public static int receive0(int arg0, Dova.JDK.sun.nio.ch.sctp.ResultContainer arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Association;)Z", "private")]
	public bool checkAssociation(Dova.JDK.com.sun.nio.sctp.Association arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Association;I)V", "private")]
	public void checkStreamNumber(Dova.JDK.com.sun.nio.sctp.Association arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void senderCleanup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("(ILjava/nio/ByteBuffer;Ljava/net/SocketAddress;IIZI)I", "private")]
	public int sendFromNativeBuffer(int arg0, Dova.JDK.java.nio.ByteBuffer arg1, Dova.JDK.java.net.SocketAddress arg2, int arg3, int arg4, bool arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(IJILjava/net/InetAddress;IIIZI)I", "private static")]
	public static int send0(int arg0, long arg1, int arg2, Dova.JDK.java.net.InetAddress arg3, int arg4, int arg5, int arg6, bool arg7, int arg8)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpMultiChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpMultiChannel unbindAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpMultiChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getAllLocalAddresses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/nio/sctp/Association;", "private")]
	public Dova.JDK.com.sun.nio.sctp.Association lookupAssociation(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.Association>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Association;)V", "private")]
	public void removeAssociation(Dova.JDK.com.sun.nio.sctp.Association arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Association;)V", "private")]
	public void addAssociation(Dova.JDK.com.sun.nio.sctp.Association arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpMultiChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpMultiChannel bindAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpMultiChannel>(ret);
	}

	[JniSignatureAttribute("(IILsun/nio/ch/SelectionKeyImpl;)Z", "private")]
	public bool translateReadyOps(int arg0, int arg1, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getFDVal()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateAndUpdateReadyOps(int arg0, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateAndSetReadyOps(int arg0, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int translateInterestOps(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isBound()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/SctpSocketOption;Lcom/sun/nio/sctp/Association;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getOption(Dova.JDK.com.sun.nio.sctp.SctpSocketOption arg0, Dova.JDK.com.sun.nio.sctp.Association arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/SctpSocketOption;Ljava/lang/Object;Lcom/sun/nio/sctp/Association;)Lcom/sun/nio/sctp/SctpMultiChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpMultiChannel setOption(Dova.JDK.com.sun.nio.sctp.SctpSocketOption arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.com.sun.nio.sctp.Association arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpMultiChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public final")]
	public Dova.JDK.java.util.Set supportedOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;", "private static final")]
	public partial class ChannelState
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChannelState()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNINITIALIZED", "Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "KILLPENDING", "Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "KILLED", "Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ChannelState", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;"));
		}

		[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;", "public static final")]
		public static Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState UNINITIALIZED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;", "public static final")]
		public static Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState KILLPENDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;", "public static final")]
		public static Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState KILLED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;", "private static final")]
		public static JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChannelState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ChannelState(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;", "public static")]
		public static JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;", "public static")]
		public static Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState>(ret);
		}

		[JniSignatureAttribute("()[Lsun/nio/ch/sctp/SctpMultiChannelImpl$ChannelState;", "private static")]
		public static JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl.ChannelState>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl$InternalNotificationHandler;", "private")]
	public partial class InternalNotificationHandler
		: Dova.JDK.com.sun.nio.sctp.AbstractNotificationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InternalNotificationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/sctp/SctpMultiChannelImpl$InternalNotificationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lsun/nio/ch/sctp/SctpMultiChannelImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "InternalNotificationHandler", "(Lsun/nio/ch/sctp/SctpMultiChannelImpl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleNotification", "(Lcom/sun/nio/sctp/AssociationChangeNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;"));
		}

		[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl;", "final")]
		public Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InternalNotificationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/nio/ch/sctp/SctpMultiChannelImpl;)V", "private")]
		public InternalNotificationHandler(Dova.JDK.sun.nio.ch.sctp.SctpMultiChannelImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/sctp/SctpMultiChannelImpl$InternalNotificationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/nio/sctp/AssociationChangeNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;", "public")]
		public Dova.JDK.com.sun.nio.sctp.HandlerResult handleNotification(Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.HandlerResult>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpMultiChannelImpl$DefaultOptionsHolder;", "private static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/sctp/SctpMultiChannelImpl$DefaultOptionsHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "defaultOptions", "Ljava/util/Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DefaultOptionsHolder", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "defaultOptions", "()Ljava/util/Set;"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "static final")]
		public static Dova.JDK.java.util.Set defaultOptions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultOptionsHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DefaultOptionsHolder() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/sctp/SctpMultiChannelImpl$DefaultOptionsHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Set;", "private static")]
		public static Dova.JDK.java.util.Set defaultOptions()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
	}
}
