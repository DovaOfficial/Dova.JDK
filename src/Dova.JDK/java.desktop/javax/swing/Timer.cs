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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/Timer;", "public")]
public partial class Timer
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Timer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/Timer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listenerList", "Ljavax/swing/event/EventListenerList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "notify", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialDelay", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delay", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "repeats", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "coalesce", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doPostEvent", "Ljava/lang/Runnable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "logTimers", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lock", "Ljava/util/concurrent/locks/Lock;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delayedTimer", "Ljavax/swing/TimerQueue$DelayedTimer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actionCommand", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acc", "Ljava/security/AccessControlContext;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/awt/event/ActionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readResolve", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "post", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkDelay", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancelEvent", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timerQueue", "()Ljavax/swing/TimerQueue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitialDelay", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLock", "()Ljava/util/concurrent/locks/Lock;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDelay", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireActionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setLogTimers", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLogTimers", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDelay", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInitialDelay", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRepeats", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRepeats", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCoalesce", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCoalesce", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restart", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addActionListener", "(Ljava/awt/event/ActionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setActionCommand", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeActionListener", "(Ljava/awt/event/ActionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActionListeners", "()[Ljava/awt/event/ActionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRunning", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListeners", "(Ljava/lang/Class;)[Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessControlContext", "()Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActionCommand", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljavax/swing/event/EventListenerList;", "protected")]
	public Dova.JDK.javax.swing.@event.EventListenerList listenerList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.EventListenerList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "private final transient")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean notify_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private volatile")]
	public int initialDelay_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private volatile")]
	public int delay_Property
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

	[JniSignatureAttribute("Z", "private volatile")]
	public bool repeats_Property
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

	[JniSignatureAttribute("Z", "private volatile")]
	public bool coalesce_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Runnable;", "private final transient")]
	public Dova.JDK.java.lang.Runnable doPostEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static volatile")]
	public static bool logTimers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/locks/Lock;", "private final transient")]
	public Dova.JDK.java.util.concurrent.locks.Lock @lock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/TimerQueue$DelayedTimer;", "transient")]
	public Dova.JDK.javax.swing.TimerQueue.DelayedTimer delayedTimer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.TimerQueue.DelayedTimer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private volatile")]
	public Dova.JDK.java.lang.String actionCommand_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private transient volatile")]
	public Dova.JDK.java.security.AccessControlContext acc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Timer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/awt/event/ActionListener;)V", "public")]
	public Timer(int arg0, Dova.JDK.java.awt.@event.ActionListener arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/Timer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void start()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void stop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object readResolve()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void post()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "private static")]
	public static void checkDelay(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void cancelEvent()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()Ljavax/swing/TimerQueue;", "private")]
	public Dova.JDK.javax.swing.TimerQueue timerQueue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.TimerQueue>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getInitialDelay()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/concurrent/locks/Lock;", "")]
	public Dova.JDK.java.util.concurrent.locks.Lock getLock()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDelay()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "protected")]
	public void fireActionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public static")]
	public static void setLogTimers(bool arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool getLogTimers()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setDelay(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setInitialDelay(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setRepeats(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRepeats()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setCoalesce(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isCoalesce()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void restart()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionListener;)V", "public")]
	public void addActionListener(Dova.JDK.java.awt.@event.ActionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setActionCommand(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionListener;)V", "public")]
	public void removeActionListener(Dova.JDK.java.awt.@event.ActionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()[Ljava/awt/event/ActionListener;", "public")]
	public JavaArray<Dova.JDK.java.awt.@event.ActionListener> getActionListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.@event.ActionListener>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRunning()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/util/EventListener;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getListeners(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/AccessControlContext;", "final")]
	public Dova.JDK.java.security.AccessControlContext getAccessControlContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getActionCommand()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/Timer$DoPostEvent;", "")]
	public partial class DoPostEvent
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DoPostEvent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/Timer$DoPostEvent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/Timer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/Timer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimer", "()Ljavax/swing/Timer;"));
		}

		[JniSignatureAttribute("Ljavax/swing/Timer;", "final")]
		public Dova.JDK.javax.swing.Timer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Timer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DoPostEvent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/Timer;)V", "")]
		public DoPostEvent(Dova.JDK.javax.swing.Timer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/Timer$DoPostEvent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Ljavax/swing/Timer;", "")]
		public Dova.JDK.javax.swing.Timer getTimer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Timer>(ret);
		}
	}
}
