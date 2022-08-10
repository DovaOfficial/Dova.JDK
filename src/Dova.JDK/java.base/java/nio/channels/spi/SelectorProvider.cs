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

namespace Dova.JDK.java.nio.channels.spi;

[JniSignatureAttribute("Ljava/nio/channels/spi/SelectorProvider;", "public abstract")]
public partial class SelectorProvider
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SelectorProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/spi/SelectorProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SelectorProvider", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SelectorProvider", "(Ljava/lang/Void;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "checkPermission", "()Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "provider", "()Ljava/nio/channels/spi/SelectorProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inheritedChannel", "()Ljava/nio/channels/Channel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openDatagramChannel", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openPipe", "()Ljava/nio/channels/Pipe;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openServerSocketChannel", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/ServerSocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openSocketChannel", "()Ljava/nio/channels/SocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "openSocketChannel", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/SocketChannel;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SelectorProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public SelectorProvider() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Void;)V", "private")]
	public SelectorProvider(Dova.JDK.java.lang.Void arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/channels/spi/SelectorProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Void;", "private static")]
	public static Dova.JDK.java.lang.Void checkPermission()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/spi/SelectorProvider;", "public static")]
	public static Dova.JDK.java.nio.channels.spi.SelectorProvider provider()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.SelectorProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/Channel;", "public")]
	public Dova.JDK.java.nio.channels.Channel inheritedChannel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.Channel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.DatagramChannel openDatagramChannel(Dova.JDK.java.net.ProtocolFamily arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/DatagramChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.DatagramChannel openDatagramChannel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.DatagramChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/Pipe;", "public abstract")]
	public Dova.JDK.java.nio.channels.Pipe openPipe()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.Pipe>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/spi/AbstractSelector;", "public abstract")]
	public Dova.JDK.java.nio.channels.spi.AbstractSelector openSelector()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.AbstractSelector>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/ProtocolFamily;)Ljava/nio/channels/ServerSocketChannel;", "public")]
	public Dova.JDK.java.nio.channels.ServerSocketChannel openServerSocketChannel(Dova.JDK.java.net.ProtocolFamily arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.ServerSocketChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/ServerSocketChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.ServerSocketChannel openServerSocketChannel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.ServerSocketChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/SocketChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.SocketChannel openSocketChannel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SocketChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/ProtocolFamily;)Ljava/nio/channels/SocketChannel;", "public")]
	public Dova.JDK.java.nio.channels.SocketChannel openSocketChannel(Dova.JDK.java.net.ProtocolFamily arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SocketChannel>(ret);
	}

	[JniSignatureAttribute("Ljava/nio/channels/spi/SelectorProvider$Holder;", "private static")]
	public partial class Holder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Holder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/spi/SelectorProvider$Holder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSTANCE", "Ljava/nio/channels/spi/SelectorProvider;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Holder", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "provider", "()Ljava/nio/channels/spi/SelectorProvider;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "loadProviderFromProperty", "()Ljava/nio/channels/spi/SelectorProvider;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "loadProviderAsService", "()Ljava/nio/channels/spi/SelectorProvider;"));
		}

		[JniSignatureAttribute("Ljava/nio/channels/spi/SelectorProvider;", "static final")]
		public static Dova.JDK.java.nio.channels.spi.SelectorProvider INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.SelectorProvider>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Holder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Holder() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/nio/channels/spi/SelectorProvider$Holder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/nio/channels/spi/SelectorProvider;", "static")]
		public static Dova.JDK.java.nio.channels.spi.SelectorProvider provider()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.SelectorProvider>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/channels/spi/SelectorProvider;", "private static")]
		public static Dova.JDK.java.nio.channels.spi.SelectorProvider loadProviderFromProperty()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.SelectorProvider>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/channels/spi/SelectorProvider;", "private static")]
		public static Dova.JDK.java.nio.channels.spi.SelectorProvider loadProviderAsService()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.SelectorProvider>(ret);
		}
	}
}
