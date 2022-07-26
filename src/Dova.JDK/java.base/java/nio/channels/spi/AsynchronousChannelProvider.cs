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

namespace Dova.JDK.java.nio.channels.spi;

[JniSignatureAttribute("Ljava/nio/channels/spi/AsynchronousChannelProvider;", "public abstract")]
public partial class AsynchronousChannelProvider
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AsynchronousChannelProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/spi/AsynchronousChannelProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Void;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkPermission", "()Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "provider", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openAsynchronousSocketChannel", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousSocketChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openAsynchronousChannelGroup", "(Ljava/util/concurrent/ExecutorService;I)Ljava/nio/channels/AsynchronousChannelGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openAsynchronousChannelGroup", "(ILjava/util/concurrent/ThreadFactory;)Ljava/nio/channels/AsynchronousChannelGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openAsynchronousServerSocketChannel", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousServerSocketChannel;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AsynchronousChannelProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public AsynchronousChannelProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Void;)V", "private")]
	public AsynchronousChannelProvider(Dova.JDK.java.lang.Void arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/channels/spi/AsynchronousChannelProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Void;", "private static")]
	public static Dova.JDK.java.lang.Void checkPermission()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/spi/AsynchronousChannelProvider;", "public static")]
	public static Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider provider()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousSocketChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.AsynchronousSocketChannel openAsynchronousSocketChannel(Dova.JDK.java.nio.channels.AsynchronousChannelGroup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousSocketChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/ExecutorService;I)Ljava/nio/channels/AsynchronousChannelGroup;", "public abstract")]
	public Dova.JDK.java.nio.channels.AsynchronousChannelGroup openAsynchronousChannelGroup(Dova.JDK.java.util.concurrent.ExecutorService arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousChannelGroup>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/concurrent/ThreadFactory;)Ljava/nio/channels/AsynchronousChannelGroup;", "public abstract")]
	public Dova.JDK.java.nio.channels.AsynchronousChannelGroup openAsynchronousChannelGroup(int arg0, Dova.JDK.java.util.concurrent.ThreadFactory arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousChannelGroup>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousServerSocketChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.AsynchronousServerSocketChannel openAsynchronousServerSocketChannel(Dova.JDK.java.nio.channels.AsynchronousChannelGroup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousServerSocketChannel>(ret);
	}

	[JniSignatureAttribute("Ljava/nio/channels/spi/AsynchronousChannelProvider$ProviderHolder;", "private static")]
	public partial class ProviderHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProviderHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/spi/AsynchronousChannelProvider$ProviderHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "provider", "Ljava/nio/channels/spi/AsynchronousChannelProvider;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadProviderFromProperty", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadProviderAsService", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;"));
		}

		[JniSignatureAttribute("Ljava/nio/channels/spi/AsynchronousChannelProvider;", "static final")]
		public static Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider provider_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ProviderHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ProviderHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/nio/channels/spi/AsynchronousChannelProvider$ProviderHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/nio/channels/spi/AsynchronousChannelProvider;", "private static")]
		public static Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider load()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/channels/spi/AsynchronousChannelProvider;", "private static")]
		public static Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider loadProviderFromProperty()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/channels/spi/AsynchronousChannelProvider;", "private static")]
		public static Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider loadProviderAsService()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.AsynchronousChannelProvider>(ret);
		}
	}
}
