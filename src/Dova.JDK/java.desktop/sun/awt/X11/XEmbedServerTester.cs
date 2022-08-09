/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XEmbedServerTester;", "public")]
public partial class XEmbedServerTester
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.awt.X11.XEventDispatcher
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XEmbedServerTester()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/X11/XEmbedServerTester;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "xembedLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "EVENT_LOCK", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SYSTEM_EVENT_MASK", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "my_version", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "server_version", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "xembed", "Lsun/awt/X11/XEmbedHelper;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "focused", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "focusedKind", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "focusedServerComponent", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "reparent", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "parent", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "windowActive", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "xembedActive", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "window", "Lsun/awt/X11/XBaseWindow;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "eventWaited", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "eventReceived", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "mapped", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "accel_key", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "accel_keysym", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "accel_mods", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "initialBounds", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "robot", "Ljava/awt/Robot;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "serverBounds", "[Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SERVER_BOUNDS", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER_FRAME", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SERVER_FOCUS", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SERVER_MODAL", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MODAL_CLOSE", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "events", "Ljava/util/LinkedList;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XEmbedServerTester", "([Ljava/awt/Rectangle;J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sleep", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispatchEvent", "(Lsun/awt/X11/XEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "requestFocus", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sendMessage", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sendMessage", "(IIJJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "initAccel", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "embedCompletely", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "waitWindowActivated", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "deactivateServer", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getEventPos", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "activateServer", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "waitFocusGained", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkFocusGained", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "requestFocusNoWait", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkNotFocused", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkWindowActivated", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkFocused", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "focusServer", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkFocusLost", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "focusServerNext", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkFocusedServerNext", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "focusServerPrev", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkFocusedServerPrev", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "activateServerNoWait", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkEventList", "(II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkMapped", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "updateEmbedInfo", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkNotMapped", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "registerAccelerator", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pressAccelKey", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "waitForEvent", "(II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "unregisterAccelerator", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "grabKey", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "waitSystemEvent", "(II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ungrabKey", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "showModalDialog", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hideModalDialog", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "embed", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "waitEmbeddedNotify", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "waitWindowDeactivated", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "waitFocusLost", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dumpReceivedEvents", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getTester", "([Ljava/awt/Rectangle;J)Lsun/awt/X11/XEmbedServerTester;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test1_1", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test1_2", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test1_3", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test1_4", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test1_5", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test1_6", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test1_7", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test2_5", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test2_6", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test3_1", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test3_3", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test3_4", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test3_5", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test3_6", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test4_1", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test4_2", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test4_3", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test4_4", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test6_1_1", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test6_1_2", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test6_1_3", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test6_1_4", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test6_2_1", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test6_2_2", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test6_2_3", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test6_2_4", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test7_1", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test7_2", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "test9_1", "()V"));
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger xembedLog_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object EVENT_LOCK_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SYSTEM_EVENT_MASK_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "")]
	public int my_version_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("I", "")]
	public int server_version_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("Lsun/awt/X11/XEmbedHelper;", "")]
	public Dova.JDK.sun.awt.X11.XEmbedHelper xembed_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XEmbedHelper>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "")]
	public bool focused_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("I", "")]
	public int focusedKind_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("I", "")]
	public int focusedServerComponent_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("Z", "")]
	public bool reparent_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("J", "")]
	public long parent_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("Z", "")]
	public bool windowActive_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("Z", "")]
	public bool xembedActive_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("Lsun/awt/X11/XBaseWindow;", "")]
	public Dova.JDK.sun.awt.X11.XBaseWindow window_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XBaseWindow>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "volatile")]
	public int eventWaited_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
	}

	[JniSignatureAttribute("I", "volatile")]
	public int eventReceived_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("I", "")]
	public int mapped_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
	}

	[JniSignatureAttribute("I", "")]
	public int accel_key_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
	}

	[JniSignatureAttribute("I", "")]
	public int accel_keysym_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
	}

	[JniSignatureAttribute("I", "")]
	public int accel_mods_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "static")]
	public static Dova.JDK.java.awt.Rectangle initialBounds_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/Robot;", "")]
	public Dova.JDK.java.awt.Robot robot_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Robot>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/awt/Rectangle;", "")]
	public JavaArray<Dova.JDK.java.awt.Rectangle> serverBounds_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Rectangle>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SERVER_BOUNDS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int OTHER_FRAME_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SERVER_FOCUS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SERVER_MODAL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MODAL_CLOSE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
	}

	[JniSignatureAttribute("Ljava/util/LinkedList;", "")]
	public Dova.JDK.java.util.LinkedList events_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedList>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XEmbedServerTester(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Ljava/awt/Rectangle;J)V", "private")]
	public XEmbedServerTester(JavaArray<Dova.JDK.java.awt.Rectangle> arg0, long arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XEmbedServerTester;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)V", "private")]
	public void sleep(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public")]
	public void dispatchEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()I", "private")]
	public int requestFocus()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void sendMessage(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(IIJJ)V", "private")]
	public void sendMessage(int arg0, int arg1, long arg2, long arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initAccel()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()I", "private")]
	public int embedCompletely()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void waitWindowActivated(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()I", "private")]
	public int deactivateServer()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int getEventPos()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int activateServer(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void waitFocusGained(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void checkFocusGained(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()I", "private")]
	public int requestFocusNoWait()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkNotFocused()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkWindowActivated()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkFocused()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()I", "private")]
	public int focusServer()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkFocusLost()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("()I", "private")]
	public int focusServerNext()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkFocusedServerNext()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()I", "private")]
	public int focusServerPrev()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkFocusedServerPrev()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int activateServerNoWait(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "private")]
	public int checkEventList(int arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkMapped()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void updateEmbedInfo()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkNotMapped()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void registerAccelerator()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28]);
	}

	[JniSignatureAttribute("()I", "private")]
	public int pressAccelKey()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void waitForEvent(int arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void unregisterAccelerator()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void grabKey()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32]);
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void waitSystemEvent(int arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ungrabKey()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("()I", "private")]
	public int showModalDialog()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int hideModalDialog()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int embed()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void waitEmbeddedNotify(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void waitWindowDeactivated(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void waitFocusLost(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void dumpReceivedEvents()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41]);
	}

	[JniSignatureAttribute("([Ljava/awt/Rectangle;J)Lsun/awt/X11/XEmbedServerTester;", "public static")]
	public static Dova.JDK.sun.awt.X11.XEmbedServerTester getTester(JavaArray<Dova.JDK.java.awt.Rectangle> arg0, long arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XEmbedServerTester>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test1_1()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test1_2()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test1_3()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test1_4()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test1_5()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test1_6()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test1_7()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test2_5()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test2_6()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test3_1()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test3_3()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test3_4()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test3_5()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test3_6()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test4_1()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test4_2()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test4_3()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test4_4()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test6_1_1()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test6_1_2()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test6_1_3()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test6_1_4()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test6_2_1()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test6_2_2()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test6_2_3()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test6_2_4()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test7_1()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test7_2()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void test9_1()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71]);
	}
}