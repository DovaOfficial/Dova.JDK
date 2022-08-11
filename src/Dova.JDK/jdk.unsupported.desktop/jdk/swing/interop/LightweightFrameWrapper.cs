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

namespace Dova.JDK.jdk.swing.interop;

[JniSignatureAttribute("Ljdk/swing/interop/LightweightFrameWrapper;", "public")]
public partial class LightweightFrameWrapper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LightweightFrameWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/swing/interop/LightweightFrameWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lwFrame", "Lsun/swing/JLightweightFrame;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyEvent", "(Ljdk/swing/interop/LightweightFrameWrapper;IJIIC)Ljava/awt/event/KeyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createUngrabEvent", "(Ljdk/swing/interop/LightweightFrameWrapper;)Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMouseEvent", "(Ljdk/swing/interop/LightweightFrameWrapper;IJIIIIIIZI)Ljava/awt/event/MouseEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMouseWheelEvent", "(Ljdk/swing/interop/LightweightFrameWrapper;IIII)Ljava/awt/event/MouseWheelEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompEqual", "(Ljava/awt/Component;Ljdk/swing/interop/LightweightFrameWrapper;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notifyDisplayChanged", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findComponentAt", "(Ljdk/swing/interop/LightweightFrameWrapper;IIZ)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addWindowFocusListener", "(Ljava/awt/event/WindowFocusListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLightweightFrame", "()Lsun/swing/JLightweightFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContent", "(Ljdk/swing/interop/LightweightContentWrapper;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overrideNativeWindowHandle", "(JLjava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emulateActivation", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHostBounds", "(IIII)V"));
	}

	[JniSignatureAttribute("Lsun/swing/JLightweightFrame;", "")]
	public Dova.JDK.sun.swing.JLightweightFrame lwFrame_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.JLightweightFrame>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LightweightFrameWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public LightweightFrameWrapper() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/swing/interop/LightweightFrameWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;IJIIC)Ljava/awt/event/KeyEvent;", "public")]
	public Dova.JDK.java.awt.@event.KeyEvent createKeyEvent(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0, int arg1, long arg2, int arg3, int arg4, char arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.KeyEvent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;)Ljava/awt/AWTEvent;", "public")]
	public Dova.JDK.java.awt.AWTEvent createUngrabEvent(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;IJIIIIIIZI)Ljava/awt/event/MouseEvent;", "public")]
	public Dova.JDK.java.awt.@event.MouseEvent createMouseEvent(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, bool arg9, int arg10)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseEvent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;IIII)Ljava/awt/event/MouseWheelEvent;", "public")]
	public Dova.JDK.java.awt.@event.MouseWheelEvent createMouseWheelEvent(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseWheelEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljdk/swing/interop/LightweightFrameWrapper;)Z", "public")]
	public bool isCompEqual(Dova.JDK.java.awt.Component arg0, Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void notifyDisplayChanged(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;IIZ)Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component findComponentAt(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0, int arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void setBounds(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowFocusListener;)V", "public")]
	public void addWindowFocusListener(Dova.JDK.java.awt.@event.WindowFocusListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/JLightweightFrame;", "private")]
	public Dova.JDK.sun.swing.JLightweightFrame getLightweightFrame()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.JLightweightFrame>(ret);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightContentWrapper;)V", "public")]
	public void setContent(Dova.JDK.jdk.swing.interop.LightweightContentWrapper arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(JLjava/lang/Runnable;)V", "")]
	public void overrideNativeWindowHandle(long arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void emulateActivation(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void setHostBounds(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}
}
