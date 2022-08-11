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

namespace Dova.JDK.sun.nio.ch.sctp;

[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpServerChannelImpl;", "public")]
public partial class SctpServerChannelImpl
	: Dova.JDK.com.sun.nio.sctp.SctpServerChannel
	, Dova.JDK.sun.nio.ch.SelChImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SctpServerChannelImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/sctp/SctpServerChannelImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fd", "Ljava/io/FileDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fdVal", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thread", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stateLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "port", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localAddresses", "Ljava/util/HashSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wildcard", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "()Lcom/sun/nio/sctp/SctpChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFD", "()Ljava/io/FileDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kill", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implCloseSelectableChannel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implConfigureBlocking", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bindUnbindAddress", "(Ljava/net/InetAddress;Z)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unbindAddress", "(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllLocalAddresses", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bindAddress", "(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateReadyOps", "(IILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFDVal", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateAndUpdateReadyOps", "(ILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateAndSetReadyOps", "(ILsun/nio/ch/SelectionKeyImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateInterestOps", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBound", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOption", "(Lcom/sun/nio/sctp/SctpSocketOption;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOption", "(Lcom/sun/nio/sctp/SctpSocketOption;Ljava/lang/Object;)Lcom/sun/nio/sctp/SctpServerChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportedOptions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptCleanup", "()V"));
	}

	[JniSignatureAttribute("Ljava/io/FileDescriptor;", "private final")]
	public Dova.JDK.java.io.FileDescriptor fd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int fdVal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("J", "private volatile")]
	public long thread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object @lock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object stateLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "private")]
	public Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int port_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashSet;", "private")]
	public Dova.JDK.java.util.HashSet localAddresses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool wildcard_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SctpServerChannelImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;)V", "public")]
	public SctpServerChannelImpl(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/sctp/SctpServerChannelImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/SctpChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpChannel accept()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/FileDescriptor;", "public")]
	public Dova.JDK.java.io.FileDescriptor getFD()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/SctpServerChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel bind(Dova.JDK.java.net.SocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void kill()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void implCloseSelectableChannel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void implConfigureBlocking(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;Z)Lcom/sun/nio/sctp/SctpServerChannel;", "private")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel bindUnbindAddress(Dova.JDK.java.net.InetAddress arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpServerChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel unbindAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getAllLocalAddresses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Lcom/sun/nio/sctp/SctpServerChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel bindAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("(IILsun/nio/ch/SelectionKeyImpl;)Z", "private")]
	public bool translateReadyOps(int arg0, int arg1, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getFDVal()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateAndUpdateReadyOps(int arg0, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/nio/ch/SelectionKeyImpl;)Z", "public")]
	public bool translateAndSetReadyOps(int arg0, Dova.JDK.sun.nio.ch.SelectionKeyImpl arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int translateInterestOps(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isBound()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/SctpSocketOption;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getOption(Dova.JDK.com.sun.nio.sctp.SctpSocketOption arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/SctpSocketOption;Ljava/lang/Object;)Lcom/sun/nio/sctp/SctpServerChannel;", "public")]
	public Dova.JDK.com.sun.nio.sctp.SctpServerChannel setOption(Dova.JDK.com.sun.nio.sctp.SctpSocketOption arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.SctpServerChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public final")]
	public Dova.JDK.java.util.Set supportedOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void acceptCleanup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "private static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNINITIALIZED", "Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INUSE", "Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KILLPENDING", "Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KILLED", "Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;"));
		}

		[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "public static final")]
		public static Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState UNINITIALIZED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "public static final")]
		public static Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState INUSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "public static final")]
		public static Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState KILLPENDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "public static final")]
		public static Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState KILLED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "private static final")]
		public static JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChannelState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ChannelState(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "public static")]
		public static JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "public static")]
		public static Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState>(ret);
		}

		[JniSignatureAttribute("()[Lsun/nio/ch/sctp/SctpServerChannelImpl$ChannelState;", "private static")]
		public static JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.nio.ch.sctp.SctpServerChannelImpl.ChannelState>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/sctp/SctpServerChannelImpl$DefaultOptionsHolder;", "private static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/sctp/SctpServerChannelImpl$DefaultOptionsHolder;");
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

		public override string GetJavaClassSignature() => "Lsun/nio/ch/sctp/SctpServerChannelImpl$DefaultOptionsHolder;";
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
