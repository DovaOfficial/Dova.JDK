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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/EventQueue;", "public")]
public partial class EventQueue
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EventQueue()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/EventQueue;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "threadInitNumber", "Ljava/util/concurrent/atomic/AtomicInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOW_PRIORITY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORM_PRIORITY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HIGH_PRIORITY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ULTIMATE_PRIORITY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NUM_PRIORITIES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "queues", "[Ljava/awt/Queue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextQueue", "Ljava/awt/EventQueue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousQueue", "Ljava/awt/EventQueue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pushPopLock", "Ljava/util/concurrent/locks/Lock;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pushPopCond", "Ljava/util/concurrent/locks/Condition;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dummyRunnable", "Ljava/lang/Runnable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dispatchThread", "Ljava/awt/EventDispatchThread;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "threadGroup", "Ljava/lang/ThreadGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mostRecentEventTime", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mostRecentKeyEventTime", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentEvent", "Ljava/lang/ref/WeakReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "waitForID", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appContext", "Lsun/awt/AppContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fwDispatcher", "Lsun/awt/FwDispatcher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "eventLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fxAppThreadIsDispatchThread", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PAINT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPDATE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MOVE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DRAG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PEER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHE_LENGTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaSecurityAccess", "Ljdk/internal/access/JavaSecurityAccess;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPriority", "(Ljava/awt/AWTEvent;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "push", "(Ljava/awt/EventQueue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMostRecentEventTime", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeAndWait", "(Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeAndWait", "(Ljava/lang/Object;Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeLater", "(Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wakeup", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDispatchThreadImpl", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noEvents", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postEventPrivate", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initDispatchThread", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "coalesceEvent", "(Ljava/awt/AWTEvent;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cacheEQItem", "(Lsun/awt/EventQueueItem;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "coalescePaintEvent", "(Ljava/awt/event/PaintEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eventToCacheIndex", "(Ljava/awt/AWTEvent;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergePaintEvents", "(Ljava/awt/event/PaintEvent;Ljava/awt/event/PaintEvent;)Ljava/awt/event/PaintEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "coalescePeerEvent", "(Lsun/awt/PeerEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "coalesceOtherEvent", "(Ljava/awt/AWTEvent;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "coalesceMouseEvent", "(Ljava/awt/event/MouseEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextEventPrivate", "()Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uncacheEQItem", "(Lsun/awt/EventQueueItem;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessControlContextFrom", "(Ljava/lang/Object;)Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurrentEventAndMostRecentTimeImpl", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEventLog", "()Lsun/util/logging/PlatformLogger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMostRecentEventTimeImpl", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentEventImpl", "()Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peekEvent", "()Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "peekEvent", "(I)Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSecondaryLoop", "(Ljava/awt/Conditional;Ljava/awt/EventFilter;J)Ljava/awt/SecondaryLoop;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSecondaryLoop", "()Ljava/awt/SecondaryLoop;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFwDispatcher", "(Lsun/awt/FwDispatcher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextEvent", "(I)Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextEvent", "()Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMostRecentEventTimeEx", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detachDispatchThread", "(Ljava/awt/EventDispatchThread;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDispatchThread", "()Ljava/awt/EventDispatchThread;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postEvent", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postEvent", "(Ljava/awt/AWTEvent;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchEvent", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchEventImpl", "(Ljava/awt/AWTEvent;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMostRecentKeyEventTime", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDispatchThread", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCurrentEventAndMostRecentTime", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSourceEvents", "(Ljava/lang/Object;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCurrentEvent", "()Ljava/awt/AWTEvent;"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicInteger;", "private static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicInteger threadInitNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int LOW_PRIORITY_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int NORM_PRIORITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int HIGH_PRIORITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ULTIMATE_PRIORITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int NUM_PRIORITIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("[Ljava/awt/Queue;", "private")]
	public JavaArray<Dova.JDK.java.awt.Queue> queues_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Queue>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/EventQueue;", "private")]
	public Dova.JDK.java.awt.EventQueue nextQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/EventQueue;", "private")]
	public Dova.JDK.java.awt.EventQueue previousQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/Lock;", "private final")]
	public Dova.JDK.java.util.concurrent.locks.Lock pushPopLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/Condition;", "private final")]
	public Dova.JDK.java.util.concurrent.locks.Condition pushPopCond_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Condition>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Runnable;", "private static final")]
	public static Dova.JDK.java.lang.Runnable dummyRunnable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/EventDispatchThread;", "private")]
	public Dova.JDK.java.awt.EventDispatchThread dispatchThread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventDispatchThread>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadGroup;", "private final")]
	public Dova.JDK.java.lang.ThreadGroup threadGroup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
	public Dova.JDK.java.lang.ClassLoader classLoader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long mostRecentEventTime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long mostRecentKeyEventTime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/WeakReference;", "private")]
	public Dova.JDK.java.lang.@ref.WeakReference currentEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.WeakReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private volatile")]
	public int waitForID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Lsun/awt/AppContext;", "private final")]
	public Dova.JDK.sun.awt.AppContext appContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.AppContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/FwDispatcher;", "private")]
	public Dova.JDK.sun.awt.FwDispatcher fwDispatcher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.FwDispatcher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static volatile")]
	public static Dova.JDK.sun.util.logging.PlatformLogger eventLog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool fxAppThreadIsDispatchThread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int PAINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int UPDATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MOVE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DRAG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int PEER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CACHE_LENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaSecurityAccess;", "private static final")]
	public static Dova.JDK.jdk.@internal.access.JavaSecurityAccess javaSecurityAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecurityAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EventQueue(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public EventQueue() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/EventQueue;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)I", "private static")]
	public static int getPriority(Dova.JDK.java.awt.AWTEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/EventQueue;)V", "public")]
	public void push(Dova.JDK.java.awt.EventQueue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void pop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()J", "public static")]
	public static long getMostRecentEventTime()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public static")]
	public static void invokeAndWait(Dova.JDK.java.lang.Runnable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Runnable;)V", "static")]
	public static void invokeAndWait(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "public static")]
	public static void invokeLater(Dova.JDK.java.lang.Runnable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void wakeup(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Z", "final")]
	public bool isDispatchThreadImpl()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool noEvents()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "private")]
	public void postEventPrivate(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()V", "final")]
	public void initDispatchThread()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;I)Z", "private")]
	public bool coalesceEvent(Dova.JDK.java.awt.AWTEvent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/EventQueueItem;)V", "private")]
	public void cacheEQItem(Dova.JDK.sun.awt.EventQueueItem arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/PaintEvent;)Z", "private")]
	public bool coalescePaintEvent(Dova.JDK.java.awt.@event.PaintEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)I", "private static")]
	public static int eventToCacheIndex(Dova.JDK.java.awt.AWTEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/PaintEvent;Ljava/awt/event/PaintEvent;)Ljava/awt/event/PaintEvent;", "private")]
	public Dova.JDK.java.awt.@event.PaintEvent mergePaintEvents(Dova.JDK.java.awt.@event.PaintEvent arg0, Dova.JDK.java.awt.@event.PaintEvent arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.PaintEvent>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/PeerEvent;)Z", "private")]
	public bool coalescePeerEvent(Dova.JDK.sun.awt.PeerEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;I)Z", "private")]
	public bool coalesceOtherEvent(Dova.JDK.java.awt.AWTEvent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Z", "private")]
	public bool coalesceMouseEvent(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/AWTEvent;", "")]
	public Dova.JDK.java.awt.AWTEvent getNextEventPrivate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/EventQueueItem;)V", "private")]
	public void uncacheEQItem(Dova.JDK.sun.awt.EventQueueItem arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/security/AccessControlContext;", "private static")]
	public static Dova.JDK.java.security.AccessControlContext getAccessControlContextFrom(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "private")]
	public void setCurrentEventAndMostRecentTimeImpl(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger getEventLog()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
	}

	[JniSignatureAttribute("()J", "private")]
	public long getMostRecentEventTimeImpl()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/AWTEvent;", "private")]
	public Dova.JDK.java.awt.AWTEvent getCurrentEventImpl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/AWTEvent;", "public")]
	public Dova.JDK.java.awt.AWTEvent peekEvent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/AWTEvent;", "public")]
	public Dova.JDK.java.awt.AWTEvent peekEvent(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Conditional;Ljava/awt/EventFilter;J)Ljava/awt/SecondaryLoop;", "")]
	public Dova.JDK.java.awt.SecondaryLoop createSecondaryLoop(Dova.JDK.java.awt.Conditional arg0, Dova.JDK.java.awt.EventFilter arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.SecondaryLoop>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/SecondaryLoop;", "public")]
	public Dova.JDK.java.awt.SecondaryLoop createSecondaryLoop()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.SecondaryLoop>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/FwDispatcher;)V", "private")]
	public void setFwDispatcher(Dova.JDK.sun.awt.FwDispatcher arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/awt/AWTEvent;", "")]
	public Dova.JDK.java.awt.AWTEvent getNextEvent(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/AWTEvent;", "public")]
	public Dova.JDK.java.awt.AWTEvent getNextEvent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("()J", "")]
	public long getMostRecentEventTimeEx()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/EventDispatchThread;)V", "final")]
	public void detachDispatchThread(Dova.JDK.java.awt.EventDispatchThread arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/EventDispatchThread;", "final")]
	public Dova.JDK.java.awt.EventDispatchThread getDispatchThread()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventDispatchThread>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "public")]
	public void postEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;I)V", "private")]
	public void postEvent(Dova.JDK.java.awt.AWTEvent arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "protected")]
	public void dispatchEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;Ljava/lang/Object;)V", "private")]
	public void dispatchEventImpl(Dova.JDK.java.awt.AWTEvent arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
	}

	[JniSignatureAttribute("()J", "synchronized")]
	public long getMostRecentKeyEventTime()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDispatchThread()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "static")]
	public static void setCurrentEventAndMostRecentTime(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)V", "final")]
	public void removeSourceEvents(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/awt/AWTEvent;", "public static")]
	public static Dova.JDK.java.awt.AWTEvent getCurrentEvent()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("Ljava/awt/EventQueue$FwSecondaryLoopWrapper;", "private")]
	public partial class FwSecondaryLoopWrapper
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.SecondaryLoop
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FwSecondaryLoopWrapper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/EventQueue$FwSecondaryLoopWrapper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loop", "Ljava/awt/SecondaryLoop;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filter", "Ljava/awt/EventFilter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljava/awt/EventQueue;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/EventQueue;Ljava/awt/SecondaryLoop;Ljava/awt/EventFilter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exit", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enter", "()Z"));
		}

		[JniSignatureAttribute("Ljava/awt/SecondaryLoop;", "private final")]
		public Dova.JDK.java.awt.SecondaryLoop loop_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.SecondaryLoop>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/EventFilter;", "private final")]
		public Dova.JDK.java.awt.EventFilter filter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventFilter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/EventQueue;", "final")]
		public Dova.JDK.java.awt.EventQueue this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.EventQueue>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FwSecondaryLoopWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/EventQueue;Ljava/awt/SecondaryLoop;Ljava/awt/EventFilter;)V", "public")]
		public FwSecondaryLoopWrapper(Dova.JDK.java.awt.EventQueue arg0, Dova.JDK.java.awt.SecondaryLoop arg1, Dova.JDK.java.awt.EventFilter arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/EventQueue$FwSecondaryLoopWrapper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool exit()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool enter()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}
}
