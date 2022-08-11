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

namespace Dova.JDK.java.util.concurrent.locks;

[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock;", "public")]
public partial class StampedLock
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StampedLock()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/locks/StampedLock;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LG_READERS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUNIT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WBIT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RBITS", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RFULL", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABITS", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SBITS", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RSAFE", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ORIGIN", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERRUPTED", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WAITING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CANCELLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "head", "Ljava/util/concurrent/locks/StampedLock$Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tail", "Ljava/util/concurrent/locks/StampedLock$Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readLockView", "Ljava/util/concurrent/locks/StampedLock$ReadLockView;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeLockView", "Ljava/util/concurrent/locks/StampedLock$WriteLockView;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readWriteLockView", "Ljava/util/concurrent/locks/StampedLock$ReadWriteLockView;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerOverflow", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "U", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATE", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HEAD", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TAIL", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlock", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryInitializeHead", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "casTail", "(Ljava/util/concurrent/locks/StampedLock$Node;Ljava/util/concurrent/locks/StampedLock$Node;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanQueue", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancelAcquire", "(Ljava/util/concurrent/locks/StampedLock$Node;Z)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "signalNext", "(Ljava/util/concurrent/locks/StampedLock$Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeLock", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLock", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReadLockCount", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReadLockCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWriteLocked", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryReadLock", "(JLjava/util/concurrent/TimeUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryReadLock", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryWriteLock", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryWriteLock", "(JLjava/util/concurrent/TimeUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "casState", "(JJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryIncReaderOverflow", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unlockWriteState", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireWrite", "(ZZJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAcquireWrite", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acquireRead", "(ZZJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryAcquireRead", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseWrite", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryDecReaderOverflow", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlockWrite", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlockRead", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancelCowaiter", "(Ljava/util/concurrent/locks/StampedLock$ReaderNode;Ljava/util/concurrent/locks/StampedLock$ReaderNode;Z)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "signalCowaiters", "(Ljava/util/concurrent/locks/StampedLock$ReaderNode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlinkCowaiter", "(Ljava/util/concurrent/locks/StampedLock$ReaderNode;Ljava/util/concurrent/locks/StampedLock$ReaderNode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeLockInterruptibly", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLockInterruptibly", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryOptimisticRead", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryConvertToWriteLock", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryConvertToReadLock", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryConvertToOptimisticRead", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryUnlockWrite", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryUnlockRead", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReadLocked", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isWriteLockStamp", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isReadLockStamp", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLockStamp", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isOptimisticReadStamp", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asReadLock", "()Ljava/util/concurrent/locks/Lock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWriteLock", "()Ljava/util/concurrent/locks/Lock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asReadWriteLock", "()Ljava/util/concurrent/locks/ReadWriteLock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unstampedUnlockWrite", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unstampedUnlockRead", "()V"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int LG_READERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long RUNIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long WBIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long RBITS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long RFULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long ABITS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long SBITS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long RSAFE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long ORIGIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long INTERRUPTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int WAITING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int CANCELLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$Node;", "private transient volatile")]
	public Dova.JDK.java.util.concurrent.locks.StampedLock.Node head_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$Node;", "private transient volatile")]
	public Dova.JDK.java.util.concurrent.locks.StampedLock.Node tail_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$ReadLockView;", "transient")]
	public Dova.JDK.java.util.concurrent.locks.StampedLock.ReadLockView readLockView_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock.ReadLockView>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$WriteLockView;", "transient")]
	public Dova.JDK.java.util.concurrent.locks.StampedLock.WriteLockView writeLockView_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock.WriteLockView>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$ReadWriteLockView;", "transient")]
	public Dova.JDK.java.util.concurrent.locks.StampedLock.ReadWriteLockView readWriteLockView_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock.ReadWriteLockView>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private transient volatile")]
	public long state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "private transient")]
	public int readerOverflow_Property
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

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static final")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe U_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long STATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long HEAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long TAIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StampedLock(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public StampedLock() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/locks/StampedLock;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Z", "public")]
	public bool validate(long arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void unlock(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void tryInitializeHead()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$Node;Ljava/util/concurrent/locks/StampedLock$Node;)Z", "private")]
	public bool casTail(Dova.JDK.java.util.concurrent.locks.StampedLock.Node arg0, Dova.JDK.java.util.concurrent.locks.StampedLock.Node arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void cleanQueue()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$Node;Z)J", "private")]
	public long cancelAcquire(Dova.JDK.java.util.concurrent.locks.StampedLock.Node arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$Node;)V", "static final")]
	public static void signalNext(Dova.JDK.java.util.concurrent.locks.StampedLock.Node arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()J", "public")]
	public long writeLock()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long readLock()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "private")]
	public int getReadLockCount(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getReadLockCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isWriteLocked()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)J", "public")]
	public long tryReadLock(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long tryReadLock()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long tryWriteLock()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)J", "public")]
	public long tryWriteLock(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JJ)Z", "private")]
	public bool casState(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private")]
	public long tryIncReaderOverflow(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private static")]
	public static long unlockWriteState(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ZZJ)J", "private")]
	public long acquireWrite(bool arg0, bool arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()J", "private")]
	public long tryAcquireWrite()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(ZZJ)J", "private")]
	public long acquireRead(bool arg0, bool arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()J", "private")]
	public long tryAcquireRead()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private")]
	public long releaseWrite(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private")]
	public long tryDecReaderOverflow(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void unlockWrite(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void unlockRead(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$ReaderNode;Ljava/util/concurrent/locks/StampedLock$ReaderNode;Z)J", "private")]
	public long cancelCowaiter(Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode arg0, Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$ReaderNode;)V", "private static")]
	public static void signalCowaiters(Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$ReaderNode;Ljava/util/concurrent/locks/StampedLock$ReaderNode;)V", "private")]
	public void unlinkCowaiter(Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode arg0, Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("()J", "public")]
	public long writeLockInterruptibly()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long readLockInterruptibly()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long tryOptimisticRead()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long tryConvertToWriteLock(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long tryConvertToReadLock(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long tryConvertToOptimisticRead(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool tryUnlockWrite()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[38]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool tryUnlockRead()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isReadLocked()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "public static")]
	public static bool isWriteLockStamp(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[41], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "public static")]
	public static bool isReadLockStamp(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[42], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "public static")]
	public static bool isLockStamp(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "public static")]
	public static bool isOptimisticReadStamp(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/locks/Lock;", "public")]
	public Dova.JDK.java.util.concurrent.locks.Lock asReadLock()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/locks/Lock;", "public")]
	public Dova.JDK.java.util.concurrent.locks.Lock asWriteLock()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/locks/ReadWriteLock;", "public")]
	public Dova.JDK.java.util.concurrent.locks.ReadWriteLock asReadWriteLock()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReadWriteLock>(ret);
	}

	[JniSignatureAttribute("()V", "final")]
	public void unstampedUnlockWrite()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48]);
	}

	[JniSignatureAttribute("()V", "final")]
	public void unstampedUnlockRead()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49]);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$Node;", "abstract static")]
	public partial class Node
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Node()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/locks/StampedLock$Node;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prev", "Ljava/util/concurrent/locks/StampedLock$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Ljava/util/concurrent/locks/StampedLock$Node;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "waiter", "Ljava/lang/Thread;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATUS", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEXT", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREV", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "casNext", "(Ljava/util/concurrent/locks/StampedLock$Node;Ljava/util/concurrent/locks/StampedLock$Node;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrevRelaxed", "(Ljava/util/concurrent/locks/StampedLock$Node;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndUnsetStatus", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearStatus", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "casPrev", "(Ljava/util/concurrent/locks/StampedLock$Node;Ljava/util/concurrent/locks/StampedLock$Node;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStatusRelaxed", "(I)V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$Node;", "volatile")]
		public Dova.JDK.java.util.concurrent.locks.StampedLock.Node prev_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$Node;", "volatile")]
		public Dova.JDK.java.util.concurrent.locks.StampedLock.Node next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock.Node>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Thread;", "")]
		public Dova.JDK.java.lang.Thread waiter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "volatile")]
		public int status_Property
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

		[JniSignatureAttribute("J", "private static final")]
		public static long STATUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long NEXT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long PREV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Node(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Node() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/locks/StampedLock$Node;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$Node;Ljava/util/concurrent/locks/StampedLock$Node;)Z", "final")]
		public bool casNext(Dova.JDK.java.util.concurrent.locks.StampedLock.Node arg0, Dova.JDK.java.util.concurrent.locks.StampedLock.Node arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$Node;)V", "final")]
		public void setPrevRelaxed(Dova.JDK.java.util.concurrent.locks.StampedLock.Node arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(I)I", "final")]
		public int getAndUnsetStatus(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "final")]
		public void clearStatus()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$Node;Ljava/util/concurrent/locks/StampedLock$Node;)Z", "final")]
		public bool casPrev(Dova.JDK.java.util.concurrent.locks.StampedLock.Node arg0, Dova.JDK.java.util.concurrent.locks.StampedLock.Node arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "final")]
		public void setStatusRelaxed(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$ReadLockView;", "final")]
	public partial class ReadLockView
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.locks.Lock
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReadLockView()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/locks/StampedLock$ReadLockView;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljava/util/concurrent/locks/StampedLock;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/locks/StampedLock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lock", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lockInterruptibly", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryLock", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCondition", "()Ljava/util/concurrent/locks/Condition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlock", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock;", "final")]
		public Dova.JDK.java.util.concurrent.locks.StampedLock this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReadLockView(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock;)V", "")]
		public ReadLockView(Dova.JDK.java.util.concurrent.locks.StampedLock arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/locks/StampedLock$ReadLockView;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void @lock()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void lockInterruptibly()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Z", "public")]
		public bool tryLock(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool tryLock()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/locks/Condition;", "public")]
		public Dova.JDK.java.util.concurrent.locks.Condition newCondition()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Condition>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void unlock()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$WriteLockView;", "final")]
	public partial class WriteLockView
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.locks.Lock
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WriteLockView()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/locks/StampedLock$WriteLockView;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljava/util/concurrent/locks/StampedLock;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/locks/StampedLock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lock", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lockInterruptibly", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tryLock", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCondition", "()Ljava/util/concurrent/locks/Condition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unlock", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock;", "final")]
		public Dova.JDK.java.util.concurrent.locks.StampedLock this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WriteLockView(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock;)V", "")]
		public WriteLockView(Dova.JDK.java.util.concurrent.locks.StampedLock arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/locks/StampedLock$WriteLockView;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void @lock()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void lockInterruptibly()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(JLjava/util/concurrent/TimeUnit;)Z", "public")]
		public bool tryLock(long arg0, Dova.JDK.java.util.concurrent.TimeUnit arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool tryLock()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/locks/Condition;", "public")]
		public Dova.JDK.java.util.concurrent.locks.Condition newCondition()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Condition>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void unlock()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$ReadWriteLockView;", "final")]
	public partial class ReadWriteLockView
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.locks.ReadWriteLock
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReadWriteLockView()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/locks/StampedLock$ReadWriteLockView;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljava/util/concurrent/locks/StampedLock;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/locks/StampedLock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeLock", "()Ljava/util/concurrent/locks/Lock;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLock", "()Ljava/util/concurrent/locks/Lock;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock;", "final")]
		public Dova.JDK.java.util.concurrent.locks.StampedLock this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReadWriteLockView(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock;)V", "")]
		public ReadWriteLockView(Dova.JDK.java.util.concurrent.locks.StampedLock arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/locks/StampedLock$ReadWriteLockView;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/concurrent/locks/Lock;", "public")]
		public Dova.JDK.java.util.concurrent.locks.Lock writeLock()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/concurrent/locks/Lock;", "public")]
		public Dova.JDK.java.util.concurrent.locks.Lock readLock()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$ReaderNode;", "static final")]
	public partial class ReaderNode
		: Dova.JDK.java.util.concurrent.locks.StampedLock.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReaderNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/locks/StampedLock$ReaderNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cowaiters", "Ljava/util/concurrent/locks/StampedLock$ReaderNode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COWAITERS", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "casCowaiters", "(Ljava/util/concurrent/locks/StampedLock$ReaderNode;Ljava/util/concurrent/locks/StampedLock$ReaderNode;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCowaitersRelaxed", "(Ljava/util/concurrent/locks/StampedLock$ReaderNode;)V"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$ReaderNode;", "volatile")]
		public Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode cowaiters_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long COWAITERS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReaderNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ReaderNode() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/locks/StampedLock$ReaderNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$ReaderNode;Ljava/util/concurrent/locks/StampedLock$ReaderNode;)Z", "final")]
		public bool casCowaiters(Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode arg0, Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/locks/StampedLock$ReaderNode;)V", "final")]
		public void setCowaitersRelaxed(Dova.JDK.java.util.concurrent.locks.StampedLock.ReaderNode arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/StampedLock$WriterNode;", "static final")]
	public partial class WriterNode
		: Dova.JDK.java.util.concurrent.locks.StampedLock.Node
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WriterNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/locks/StampedLock$WriterNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WriterNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public WriterNode() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/concurrent/locks/StampedLock$WriterNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
