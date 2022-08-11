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

[JniSignatureAttribute("Lsun/nio/ch/AsynchronousFileChannelImpl;", "abstract")]
public partial class AsynchronousFileChannelImpl
	: Dova.JDK.java.nio.channels.AsynchronousFileChannel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AsynchronousFileChannelImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/AsynchronousFileChannelImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closeLock", "Ljava/util/concurrent/locks/ReadWriteLock;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fdObj", "Ljava/io/FileDescriptor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reading", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writing", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/ExecutorService;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileLockTable", "Lsun/nio/ch/FileLockTable;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/FileDescriptor;ZZLjava/util/concurrent/ExecutorService;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lock", "(JJZ)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lock", "(JJZLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "end", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "begin", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOpen", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "release", "(Lsun/nio/ch/FileLockImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implWrite", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executor", "()Ljava/util/concurrent/ExecutorService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implRead", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implLock", "(JJZLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implRelease", "(Lsun/nio/ch/FileLockImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureFileLockTableInitialized", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFromFileLockTable", "(Lsun/nio/ch/FileLockImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidateAllLocks", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addToFileLockTable", "(JJZ)Lsun/nio/ch/FileLockImpl;"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/ReadWriteLock;", "protected final")]
	public Dova.JDK.java.util.concurrent.locks.ReadWriteLock closeLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReadWriteLock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected volatile")]
	public bool closed_Property
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

	[JniSignatureAttribute("Ljava/io/FileDescriptor;", "protected final")]
	public Dova.JDK.java.io.FileDescriptor fdObj_Property
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

	[JniSignatureAttribute("Z", "protected final")]
	public bool reading_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "protected final")]
	public bool writing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ExecutorService;", "protected final")]
	public Dova.JDK.java.util.concurrent.ExecutorService executor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ExecutorService>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/FileLockTable;", "private volatile")]
	public Dova.JDK.sun.nio.ch.FileLockTable fileLockTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.FileLockTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AsynchronousFileChannelImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;ZZLjava/util/concurrent/ExecutorService;)V", "protected")]
	public AsynchronousFileChannelImpl(Dova.JDK.java.io.FileDescriptor arg0, bool arg1, bool arg2, Dova.JDK.java.util.concurrent.ExecutorService arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/AsynchronousFileChannelImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(JJZ)Ljava/util/concurrent/Future;", "public final")]
	public Dova.JDK.java.util.concurrent.Future @lock(long arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(JJZLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", "public final")]
	public void @lock(long arg0, long arg1, bool arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.nio.channels.CompletionHandler arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()V", "protected final")]
	public void end()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Z)V", "protected final")]
	public void end(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "protected final")]
	public void begin()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isOpen()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;", "public final")]
	public Dova.JDK.java.util.concurrent.Future write(Dova.JDK.java.nio.ByteBuffer arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", "public final")]
	public void write(Dova.JDK.java.nio.ByteBuffer arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.nio.channels.CompletionHandler arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;", "public final")]
	public Dova.JDK.java.util.concurrent.Future read(Dova.JDK.java.nio.ByteBuffer arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", "public final")]
	public void read(Dova.JDK.java.nio.ByteBuffer arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.nio.channels.CompletionHandler arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/nio/ch/FileLockImpl;)V", "final")]
	public void release(Dova.JDK.sun.nio.ch.FileLockImpl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;", "abstract")]
	public Dova.JDK.java.util.concurrent.Future implWrite(Dova.JDK.java.nio.ByteBuffer arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.nio.channels.CompletionHandler arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/ExecutorService;", "final")]
	public Dova.JDK.java.util.concurrent.ExecutorService executor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ExecutorService>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;", "abstract")]
	public Dova.JDK.java.util.concurrent.Future implRead(Dova.JDK.java.nio.ByteBuffer arg0, long arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.nio.channels.CompletionHandler arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(JJZLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)Ljava/util/concurrent/Future;", "abstract")]
	public Dova.JDK.java.util.concurrent.Future implLock(long arg0, long arg1, bool arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.nio.channels.CompletionHandler arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Future>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/ch/FileLockImpl;)V", "protected abstract")]
	public void implRelease(Dova.JDK.sun.nio.ch.FileLockImpl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()V", "final")]
	public void ensureFileLockTableInitialized()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("(Lsun/nio/ch/FileLockImpl;)V", "protected final")]
	public void removeFromFileLockTable(Dova.JDK.sun.nio.ch.FileLockImpl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()V", "final")]
	public void invalidateAllLocks()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("(JJZ)Lsun/nio/ch/FileLockImpl;", "protected final")]
	public Dova.JDK.sun.nio.ch.FileLockImpl addToFileLockTable(long arg0, long arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.FileLockImpl>(ret);
	}
}
