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

namespace Dova.JDK.java.nio.channels;

[JniSignatureAttribute("Ljava/nio/channels/Pipe;", "public abstract")]
public partial class Pipe
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Pipe()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/Pipe;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "source", "()Ljava/nio/channels/Pipe$SourceChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "open", "()Ljava/nio/channels/Pipe;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Pipe(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public Pipe() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/channels/Pipe;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/nio/channels/Pipe$SourceChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.Pipe.SourceChannel source()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.Pipe.SourceChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/Pipe;", "public static")]
	public static Dova.JDK.java.nio.channels.Pipe open()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.Pipe>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/Pipe$SinkChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.Pipe.SinkChannel sink()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.Pipe.SinkChannel>(ret);
	}

	[JniSignatureAttribute("Ljava/nio/channels/Pipe$SinkChannel;", "public abstract static")]
	public partial class SinkChannel
		: Dova.JDK.java.nio.channels.spi.AbstractSelectableChannel
		, Dova.JDK.java.nio.channels.WritableByteChannel
		, Dova.JDK.java.nio.channels.GatheringByteChannel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SinkChannel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/Pipe$SinkChannel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validOps", "()I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SinkChannel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;)V", "protected")]
		public SinkChannel(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/nio/channels/Pipe$SinkChannel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public final")]
		public int validOps()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/nio/channels/Pipe$SourceChannel;", "public abstract static")]
	public partial class SourceChannel
		: Dova.JDK.java.nio.channels.spi.AbstractSelectableChannel
		, Dova.JDK.java.nio.channels.ReadableByteChannel
		, Dova.JDK.java.nio.channels.ScatteringByteChannel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SourceChannel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/Pipe$SourceChannel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validOps", "()I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SourceChannel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/channels/spi/SelectorProvider;)V", "protected")]
		public SourceChannel(Dova.JDK.java.nio.channels.spi.SelectorProvider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/nio/channels/Pipe$SourceChannel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public final")]
		public int validOps()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}
}
