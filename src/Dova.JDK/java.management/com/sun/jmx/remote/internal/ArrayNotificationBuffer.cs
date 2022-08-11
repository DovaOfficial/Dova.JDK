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

namespace Dova.JDK.com.sun.jmx.remote.@internal;

[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;", "public")]
public partial class ArrayNotificationBuffer
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.jmx.remote.@internal.NotificationBuffer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ArrayNotificationBuffer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "disposed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "globalLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mbsToBuffer", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sharers", "Ljava/util/Collection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferListener", "Ljavax/management/NotificationListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "broadcasterQuery", "Ljavax/management/QueryExp;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "creationFilter", "Ljavax/management/NotificationFilter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "creationListener", "Ljavax/management/NotificationListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "logger", "Lcom/sun/jmx/remote/util/ClassLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mBeanServer", "Ljavax/management/MBeanServer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "queue", "Lcom/sun/jmx/remote/internal/ArrayQueue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "queueSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "earliestSequenceNumber", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextSequenceNumber", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "createdDuringQuery", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "broadcasterClass", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/MBeanServer;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resize", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeNotificationBuffer", "(Ljavax/management/MBeanServer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destroyListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropNotification", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fetchNotifications", "(Lcom/sun/jmx/remote/internal/NotificationBufferFilter;JJI)Ljavax/management/remote/NotificationResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notificationAt", "(J)Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$NamedNotification;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotification", "(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$NamedNotification;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addBufferListener", "(Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkNoLocks", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeBufferListener", "(Ljavax/management/ObjectName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extractException", "(Ljava/lang/Exception;)Ljava/lang/Exception;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createdNotification", "(Ljavax/management/MBeanServerNotification;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNotificationBuffer", "(Ljavax/management/MBeanServer;Ljava/util/Map;)Lcom/sun/jmx/remote/internal/NotificationBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSharer", "(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$ShareBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSharer", "(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$ShareBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDisposed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "earliestSequenceNumber", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextSequenceNumber", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isInstanceOf", "(Ljavax/management/MBeanServer;Ljavax/management/ObjectName;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryNames", "(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;)V"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool disposed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object globalLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
	public static Dova.JDK.java.util.HashMap mbsToBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Collection;", "private final")]
	public Dova.JDK.java.util.Collection sharers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/NotificationListener;", "private final")]
	public Dova.JDK.javax.management.NotificationListener bufferListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/QueryExp;", "private static final")]
	public static Dova.JDK.javax.management.QueryExp broadcasterQuery_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.QueryExp>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/NotificationFilter;", "private static final")]
	public static Dova.JDK.javax.management.NotificationFilter creationFilter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationFilter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/NotificationListener;", "private final")]
	public Dova.JDK.javax.management.NotificationListener creationListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.NotificationListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/util/ClassLogger;", "private static final")]
	public static Dova.JDK.com.sun.jmx.remote.util.ClassLogger logger_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.util.ClassLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/management/MBeanServer;", "private final")]
	public Dova.JDK.javax.management.MBeanServer mBeanServer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/ArrayQueue;", "private final")]
	public Dova.JDK.com.sun.jmx.remote.@internal.ArrayQueue queue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.@internal.ArrayQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int queueSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long earliestSequenceNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long nextSequenceNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set createdDuringQuery_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String broadcasterClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ArrayNotificationBuffer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;I)V", "private")]
	public ArrayNotificationBuffer(Dova.JDK.javax.management.MBeanServer arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)V", "private synchronized")]
	public void resize(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void createListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;)V", "static")]
	public static void removeNotificationBuffer(Dova.JDK.javax.management.MBeanServer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void destroyListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void dropNotification()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/remote/internal/NotificationBufferFilter;JJI)Ljavax/management/remote/NotificationResult;", "public")]
	public Dova.JDK.javax.management.remote.NotificationResult fetchNotifications(Dova.JDK.com.sun.jmx.remote.@internal.NotificationBufferFilter arg0, long arg1, long arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.NotificationResult>(ret);
	}

	[JniSignatureAttribute("(J)Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$NamedNotification;", "synchronized")]
	public Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer.NamedNotification notificationAt(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer.NamedNotification>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$NamedNotification;)V", "synchronized")]
	public void addNotification(Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer.NamedNotification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "private")]
	public void addBufferListener(Dova.JDK.javax.management.ObjectName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkNoLocks()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)V", "private")]
	public void removeBufferListener(Dova.JDK.javax.management.ObjectName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;)Ljava/lang/Exception;", "private static")]
	public static Dova.JDK.java.lang.Exception extractException(Dova.JDK.java.lang.Exception arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Exception>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServerNotification;)V", "private")]
	public void createdNotification(Dova.JDK.javax.management.MBeanServerNotification arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;Ljava/util/Map;)Lcom/sun/jmx/remote/internal/NotificationBuffer;", "public static")]
	public static Dova.JDK.com.sun.jmx.remote.@internal.NotificationBuffer getNotificationBuffer(Dova.JDK.javax.management.MBeanServer arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.@internal.NotificationBuffer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$ShareBuffer;)V", "")]
	public void addSharer(Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer.ShareBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$ShareBuffer;)V", "private")]
	public void removeSharer(Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer.ShareBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Z", "private synchronized")]
	public bool isDisposed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()J", "synchronized")]
	public long earliestSequenceNumber()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()J", "synchronized")]
	public long nextSequenceNumber()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;Ljavax/management/ObjectName;Ljava/lang/String;)Z", "private static")]
	public static bool isInstanceOf(Dova.JDK.javax.management.MBeanServer arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/QueryExp;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set queryNames(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.QueryExp arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "private")]
	public void addNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.NotificationListener arg1, Dova.JDK.javax.management.NotificationFilter arg2, Dova.JDK.java.lang.Object arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/NotificationListener;)V", "private")]
	public void removeNotificationListener(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.NotificationListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$ShareBuffer;", "private")]
	public partial class ShareBuffer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.jmx.remote.@internal.NotificationBuffer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ShareBuffer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$ShareBuffer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fetchNotifications", "(Lcom/sun/jmx/remote/internal/NotificationBufferFilter;JJI)Ljavax/management/remote/NotificationResult;"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int size_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;", "final")]
		public Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ShareBuffer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;I)V", "")]
		public ShareBuffer(Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$ShareBuffer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "")]
		public int getSize()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Lcom/sun/jmx/remote/internal/NotificationBufferFilter;JJI)Ljavax/management/remote/NotificationResult;", "public")]
		public Dova.JDK.javax.management.remote.NotificationResult fetchNotifications(Dova.JDK.com.sun.jmx.remote.@internal.NotificationBufferFilter arg0, long arg1, long arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.NotificationResult>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$BufferListener;", "private")]
	public partial class BufferListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.management.NotificationListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BufferListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$BufferListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleNotification", "(Ljavax/management/Notification;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;", "final")]
		public Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BufferListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer;)V", "private")]
		public BufferListener(Dova.JDK.com.sun.jmx.remote.@internal.ArrayNotificationBuffer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$BufferListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/management/Notification;Ljava/lang/Object;)V", "public")]
		public void handleNotification(Dova.JDK.javax.management.Notification arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$NamedNotification;", "private static")]
	public partial class NamedNotification
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NamedNotification()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$NamedNotification;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sender", "Ljavax/management/ObjectName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "notification", "Ljavax/management/Notification;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/management/ObjectName;Ljavax/management/Notification;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotification", "()Ljavax/management/Notification;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjectName", "()Ljavax/management/ObjectName;"));
		}

		[JniSignatureAttribute("Ljavax/management/ObjectName;", "private final")]
		public Dova.JDK.javax.management.ObjectName sender_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/management/Notification;", "private final")]
		public Dova.JDK.javax.management.Notification notification_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.management.Notification>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NamedNotification(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/management/ObjectName;Ljavax/management/Notification;)V", "")]
		public NamedNotification(Dova.JDK.javax.management.ObjectName arg0, Dova.JDK.javax.management.Notification arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$NamedNotification;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/management/Notification;", "")]
		public Dova.JDK.javax.management.Notification getNotification()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.Notification>(ret);
		}

		[JniSignatureAttribute("()Ljavax/management/ObjectName;", "")]
		public Dova.JDK.javax.management.ObjectName getObjectName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.ObjectName>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$BroadcasterQuery;", "private static")]
	public partial class BroadcasterQuery
		: Dova.JDK.javax.management.QueryEval
		, Dova.JDK.javax.management.QueryExp
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BroadcasterQuery()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$BroadcasterQuery;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljavax/management/ObjectName;)Z"));
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BroadcasterQuery(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public BroadcasterQuery() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jmx/remote/internal/ArrayNotificationBuffer$BroadcasterQuery;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/management/ObjectName;)Z", "public")]
		public bool apply(Dova.JDK.javax.management.ObjectName arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}
}
