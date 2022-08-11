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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XDragSourceContextPeer;", "public final")]
public partial class XDragSourceContextPeer
	: Dova.JDK.sun.awt.dnd.SunDragSourceContextPeer
	, Dova.JDK.sun.awt.X11.XDragSourceProtocolListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XDragSourceContextPeer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XDragSourceContextPeer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "logger", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROOT_EVENT_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GRAB_EVENT_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootEventMask", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dndInProgress", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dragInProgress", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dragRootWindow", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dragProtocol", "Lsun/awt/X11/XDragSourceProtocol;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetAction", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceActions", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceAction", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceFormats", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetRootSubwindow", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "windowScale", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xRoot", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yRoot", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eventState", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxyModeSourceWindow", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "theInstance", "Lsun/awt/X11/XDragSourceContextPeer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/dnd/DragGestureEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanup", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scaleUp", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processClientMessage", "(Lsun/awt/X11/XClientMessageEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scaleDown", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doProcessEvent", "(Lsun/awt/X11/XEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwGrabFailureException", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProxyModeSourceWindowImpl", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanupTargetInfo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDnDGrab", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findClientWindow", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doUpdateTargetWindow", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateSourceAction", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTargetWindow", "(Lsun/awt/X11/XMotionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyModeSourceWindow", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processProxyModeEvent", "(Lsun/awt/X11/XEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processMouseMove", "(Lsun/awt/X11/XMotionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processDrop", "(Lsun/awt/X11/XButtonEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleDragReply", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleDragReply", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleDragReply", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleDragFinished", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleDragFinished", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleDragFinished", "(ZI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleDragFinished", "(ZIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getXDragSourceProtocolListener", "()Lsun/awt/X11/XDragSourceProtocolListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setProxyModeSourceWindow", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsBogusExitBeforeDrop", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNativeCursor", "(JLjava/awt/Cursor;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDrag", "(Ljava/awt/datatransfer/Transferable;[JLjava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "processEvent", "(Lsun/awt/X11/XEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCursor", "(Ljava/awt/Cursor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDragSourceContextPeer", "(Ljava/awt/dnd/DragGestureEvent;)Lsun/awt/X11/XDragSourceContextPeer;"));
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger logger_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ROOT_EVENT_MASK_Property
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
	public static int GRAB_EVENT_MASK_Property
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

	[JniSignatureAttribute("J", "private")]
	public long rootEventMask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool dndInProgress_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool dragInProgress_Property
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

	[JniSignatureAttribute("J", "private")]
	public long dragRootWindow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XDragSourceProtocol;", "private")]
	public Dova.JDK.sun.awt.X11.XDragSourceProtocol dragProtocol_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDragSourceProtocol>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int targetAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int sourceActions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int sourceAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("[J", "private")]
	public JavaArray<long> sourceFormats_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long targetRootSubwindow_Property
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

	[JniSignatureAttribute("I", "")]
	public int windowScale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int xRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int yRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int eventState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long proxyModeSourceWindow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XDragSourceContextPeer;", "private static final")]
	public static Dova.JDK.sun.awt.X11.XDragSourceContextPeer theInstance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDragSourceContextPeer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XDragSourceContextPeer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragGestureEvent;)V", "private")]
	public XDragSourceContextPeer(Dova.JDK.java.awt.dnd.DragGestureEvent arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XDragSourceContextPeer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(J)V", "public")]
	public void cleanup(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int scaleUp(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XClientMessageEvent;)Z", "private")]
	public bool processClientMessage(Dova.JDK.sun.awt.X11.XClientMessageEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int scaleDown(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)Z", "private")]
	public bool doProcessEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public void throwGrabFailureException(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void setProxyModeSourceWindowImpl(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void cleanupTargetInfo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void removeDnDGrab(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(J)J", "private static")]
	public static long findClientWindow(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "private")]
	public void doUpdateTargetWindow(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool updateSourceAction(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XMotionEvent;)V", "private")]
	public void updateTargetWindow(Dova.JDK.sun.awt.X11.XMotionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getProxyModeSourceWindow()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)Z", "private")]
	public bool processProxyModeEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XMotionEvent;)V", "private")]
	public void processMouseMove(Dova.JDK.sun.awt.X11.XMotionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XButtonEvent;)V", "private")]
	public void processDrop(Dova.JDK.sun.awt.X11.XButtonEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void handleDragReply(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(III)V", "public")]
	public void handleDragReply(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void handleDragReply(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "public")]
	public void handleDragFinished()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void handleDragFinished(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(ZI)V", "public")]
	public void handleDragFinished(bool arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("(ZIII)V", "public")]
	public void handleDragFinished(bool arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XDragSourceProtocolListener;", "static")]
	public static Dova.JDK.sun.awt.X11.XDragSourceProtocolListener getXDragSourceProtocolListener()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDragSourceProtocolListener>(ret);
	}

	[JniSignatureAttribute("(J)V", "public static")]
	public static void setProxyModeSourceWindow(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool needsBogusExitBeforeDrop()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/awt/Cursor;I)V", "protected")]
	public void setNativeCursor(long arg0, Dova.JDK.java.awt.Cursor arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/Transferable;[JLjava/util/Map;)V", "protected")]
	public void startDrag(Dova.JDK.java.awt.datatransfer.Transferable arg0, JavaArray<long> arg1, Dova.JDK.java.util.Map arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)Z", "static")]
	public static bool processEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public")]
	public void setCursor(Dova.JDK.java.awt.Cursor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragGestureEvent;)Lsun/awt/X11/XDragSourceContextPeer;", "static")]
	public static Dova.JDK.sun.awt.X11.XDragSourceContextPeer createDragSourceContextPeer(Dova.JDK.java.awt.dnd.DragGestureEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDragSourceContextPeer>(ret);
	}
}
