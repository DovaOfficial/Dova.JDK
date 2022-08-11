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

[JniSignatureAttribute("Lsun/awt/X11/MotifDnDDragSourceProtocol;", "")]
public partial class MotifDnDDragSourceProtocol
	: Dova.JDK.sun.awt.X11.XDragSourceProtocol
	, Dova.JDK.sun.awt.X11.XEventDispatcher
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MotifDnDDragSourceProtocol()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/MotifDnDDragSourceProtocol;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetEnterServerTime", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11/XDragSourceProtocolListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createInstance", "(Lsun/awt/X11/XDragSourceProtocolListener;)Lsun/awt/X11/XDragSourceProtocol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processClientMessage", "(Lsun/awt/X11/XClientMessageEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendLeaveMessage", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanupTargetInfo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendEnterMessage", "([JIIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendMoveMessage", "(IIIIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processProxyModeEvent", "(Lsun/awt/X11/XClientMessageEvent;J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetWindowInfo", "(J)Lsun/awt/X11/XDragSourceProtocol$TargetWindowInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProtocolName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeDragImpl", "(ILjava/awt/datatransfer/Transferable;Ljava/util/Map;[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendDropMessage", "(IIIIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchEvent", "(Lsun/awt/X11/XEvent;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private static final")]
	public static Dova.JDK.jdk.@internal.misc.Unsafe @unsafe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long targetEnterServerTime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MotifDnDDragSourceProtocol(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XDragSourceProtocolListener;)V", "protected")]
	public MotifDnDDragSourceProtocol(Dova.JDK.sun.awt.X11.XDragSourceProtocolListener arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/MotifDnDDragSourceProtocol;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/awt/X11/XDragSourceProtocolListener;)Lsun/awt/X11/XDragSourceProtocol;", "static")]
	public static Dova.JDK.sun.awt.X11.XDragSourceProtocol createInstance(Dova.JDK.sun.awt.X11.XDragSourceProtocolListener arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDragSourceProtocol>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XClientMessageEvent;)Z", "public")]
	public bool processClientMessage(Dova.JDK.sun.awt.X11.XClientMessageEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void sendLeaveMessage(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void cleanupTargetInfo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("([JIIJ)V", "public")]
	public void sendEnterMessage(JavaArray<long> arg0, int arg1, int arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IIIIJ)V", "public")]
	public void sendMoveMessage(int arg0, int arg1, int arg2, int arg3, long arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XClientMessageEvent;J)Z", "public")]
	public bool processProxyModeEvent(Dova.JDK.sun.awt.X11.XClientMessageEvent arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)Lsun/awt/X11/XDragSourceProtocol$TargetWindowInfo;", "public")]
	public Dova.JDK.sun.awt.X11.XDragSourceProtocol.TargetWindowInfo getTargetWindowInfo(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDragSourceProtocol.TargetWindowInfo>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getProtocolName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/datatransfer/Transferable;Ljava/util/Map;[J)V", "protected")]
	public void initializeDragImpl(int arg0, Dova.JDK.java.awt.datatransfer.Transferable arg1, Dova.JDK.java.util.Map arg2, JavaArray<long> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IIIIJ)V", "protected")]
	public void sendDropMessage(int arg0, int arg1, int arg2, int arg3, long arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XEvent;)V", "public")]
	public void dispatchEvent(Dova.JDK.sun.awt.X11.XEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}
}
