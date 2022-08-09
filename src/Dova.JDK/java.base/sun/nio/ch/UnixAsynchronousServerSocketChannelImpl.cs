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

namespace Dova.JDK.sun.nio.ch;

[JniSignatureAttribute("Lsun/nio/ch/UnixAsynchronousServerSocketChannelImpl;", "")]
public partial class UnixAsynchronousServerSocketChannelImpl
	: Dova.JDK.sun.nio.ch.AsynchronousServerSocketChannelImpl
	, Dova.JDK.sun.nio.ch.Port.PollableChannel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnixAsynchronousServerSocketChannelImpl()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/nio/ch/UnixAsynchronousServerSocketChannelImpl;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "nd", "Lsun/nio/ch/NativeDispatcher;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "port", "Lsun/nio/ch/Port;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fdVal", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "accepting", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "updateLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "acceptPending", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "acceptHandler", "Ljava/nio/channels/CompletionHandler;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "acceptAttachment", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "acceptFuture", "Lsun/nio/ch/PendingFuture;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "acceptAcc", "Ljava/security/AccessControlContext;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnixAsynchronousServerSocketChannelImpl", "(Lsun/nio/ch/Port;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "group", "()Lsun/nio/ch/AsynchronousChannelGroupImpl;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "implClose", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "onEvent", "(IZ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "enableAccept", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "implAccept", "(Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "finishAccept", "(Ljava/io/FileDescriptor;Ljava/net/InetSocketAddress;Ljava/security/AccessControlContext;)Ljava/nio/channels/AsynchronousSocketChannel;"));
	}

	[JniSignatureAttribute("Lsun/nio/ch/NativeDispatcher;", "private static final")]
	public static Dova.JDK.sun.nio.ch.NativeDispatcher nd_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.NativeDispatcher>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/nio/ch/Port;", "private final")]
	public Dova.JDK.sun.nio.ch.Port port_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.Port>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private final")]
	public int fdVal_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "private final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean accepting_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object updateLock_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool acceptPending_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("Ljava/nio/channels/CompletionHandler;", "private")]
	public Dova.JDK.java.nio.channels.CompletionHandler acceptHandler_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.CompletionHandler>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object acceptAttachment_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/nio/ch/PendingFuture;", "private")]
	public Dova.JDK.sun.nio.ch.PendingFuture acceptFuture_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.PendingFuture>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private")]
	public Dova.JDK.java.security.AccessControlContext acceptAcc_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnixAsynchronousServerSocketChannelImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/nio/ch/Port;)V", "")]
	public UnixAsynchronousServerSocketChannelImpl(Dova.JDK.sun.nio.ch.Port arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/UnixAsynchronousServerSocketChannelImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/nio/ch/AsynchronousChannelGroupImpl;", "public")]
	public Dova.JDK.sun.nio.ch.AsynchronousChannelGroupImpl group()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.AsynchronousChannelGroupImpl>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void implClose()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(IZ)V", "public")]
	public void onEvent(int arg0, bool arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void enableAccept()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;", "")]
	public Dova.JDK.java.util.concurrent.Future implAccept(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.nio.channels.CompletionHandler arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/net/InetSocketAddress;Ljava/security/AccessControlContext;)Ljava/nio/channels/AsynchronousSocketChannel;", "private")]
	public Dova.JDK.java.nio.channels.AsynchronousSocketChannel finishAccept(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.net.InetSocketAddress arg1, Dova.JDK.java.security.AccessControlContext arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousSocketChannel>(ret);
	}
}