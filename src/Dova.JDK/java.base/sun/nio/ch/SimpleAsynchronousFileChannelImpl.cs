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

[JniSignatureAttribute("Lsun/nio/ch/SimpleAsynchronousFileChannelImpl;", "public")]
public partial class SimpleAsynchronousFileChannelImpl
	: Dova.JDK.sun.nio.ch.AsynchronousFileChannelImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleAsynchronousFileChannelImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/SimpleAsynchronousFileChannelImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nd", "Lsun/nio/ch/FileDispatcher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "threads", "Lsun/nio/ch/NativeThreadSet;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/FileDescriptor;ZZLjava/util/concurrent/ExecutorService;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "open", "(Ljava/io/FileDescriptor;ZZLsun/nio/ch/ThreadPool;)Ljava/nio/channels/AsynchronousFileChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implWrite", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "force", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implLock", "(JJZLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implRelease", "(Lsun/nio/ch/FileLockImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncate", "(J)Ljava/nio/channels/AsynchronousFileChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implRead", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;"));
	}

	[JniSignatureAttribute("Lsun/nio/ch/FileDispatcher;", "private static final")]
	public static Dova.JDK.sun.nio.ch.FileDispatcher nd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.FileDispatcher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/NativeThreadSet;", "private final")]
	public Dova.JDK.sun.nio.ch.NativeThreadSet threads_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.NativeThreadSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleAsynchronousFileChannelImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;ZZLjava/util/concurrent/ExecutorService;)V", "")]
	public SimpleAsynchronousFileChannelImpl(Dova.JDK.java.io.FileDescriptor arg0, bool arg1, bool arg2, Dova.JDK.java.util.concurrent.ExecutorService arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/SimpleAsynchronousFileChannelImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()J", "public")]
	public long size()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;ZZLsun/nio/ch/ThreadPool;)Ljava/nio/channels/AsynchronousFileChannel;", "public static")]
	public static Dova.JDK.java.nio.channels.AsynchronousFileChannel open(Dova.JDK.java.io.FileDescriptor arg0, bool arg1, bool arg2, Dova.JDK.sun.nio.ch.ThreadPool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousFileChannel>(ret);
	}

	[JniSignatureAttribute("(JJZ)Ljava/nio/channels/FileLock;", "public")]
	public Dova.JDK.java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.FileLock>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;", "")]
	public Dova.JDK.java.util.concurrent.Future implWrite(Dova.JDK.java.nio.ByteBuffer arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.nio.channels.CompletionHandler arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void force(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(JJZLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;", "")]
	public Dova.JDK.java.util.concurrent.Future implLock(long arg0, long arg1, bool arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.nio.channels.CompletionHandler arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/ch/FileLockImpl;)V", "protected")]
	public void implRelease(Dova.JDK.sun.nio.ch.FileLockImpl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(J)Ljava/nio/channels/AsynchronousFileChannel;", "public")]
	public Dova.JDK.java.nio.channels.AsynchronousFileChannel truncate(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousFileChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;", "")]
	public Dova.JDK.java.util.concurrent.Future implRead(Dova.JDK.java.nio.ByteBuffer arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.nio.channels.CompletionHandler arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("Lsun/nio/ch/SimpleAsynchronousFileChannelImpl$DefaultExecutorHolder;", "private static")]
	public partial class DefaultExecutorHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultExecutorHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/SimpleAsynchronousFileChannelImpl$DefaultExecutorHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultExecutor", "Ljava/util/concurrent/ExecutorService;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ExecutorService;", "static final")]
		public static Dova.JDK.java.util.concurrent.ExecutorService defaultExecutor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ExecutorService>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultExecutorHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DefaultExecutorHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/SimpleAsynchronousFileChannelImpl$DefaultExecutorHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
