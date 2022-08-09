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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/swing/interop/LightweightFrameWrapper;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lwFrame", "Lsun/swing/JLightweightFrame;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LightweightFrameWrapper", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setVisible", "(Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createKeyEvent", "(Ljdk/swing/interop/LightweightFrameWrapper;IJIIC)Ljava/awt/event/KeyEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createUngrabEvent", "(Ljdk/swing/interop/LightweightFrameWrapper;)Ljava/awt/AWTEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createMouseEvent", "(Ljdk/swing/interop/LightweightFrameWrapper;IJIIIIIIZI)Ljava/awt/event/MouseEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createMouseWheelEvent", "(Ljdk/swing/interop/LightweightFrameWrapper;IIII)Ljava/awt/event/MouseWheelEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isCompEqual", "(Ljava/awt/Component;Ljdk/swing/interop/LightweightFrameWrapper;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "notifyDisplayChanged", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findComponentAt", "(Ljdk/swing/interop/LightweightFrameWrapper;IIZ)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setBounds", "(IIII)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addWindowFocusListener", "(Ljava/awt/event/WindowFocusListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLightweightFrame", "()Lsun/swing/JLightweightFrame;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setContent", "(Ljdk/swing/interop/LightweightContentWrapper;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "overrideNativeWindowHandle", "(JLjava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "emulateActivation", "(Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setHostBounds", "(IIII)V"));
	}

	[JniSignatureAttribute("Lsun/swing/JLightweightFrame;", "")]
	public Dova.JDK.sun.swing.JLightweightFrame lwFrame_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.JLightweightFrame>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LightweightFrameWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public LightweightFrameWrapper() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/swing/interop/LightweightFrameWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setVisible(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;IJIIC)Ljava/awt/event/KeyEvent;", "public")]
	public Dova.JDK.java.awt.@event.KeyEvent createKeyEvent(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0, int arg1, long arg2, int arg3, int arg4, char arg5)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.KeyEvent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;)Ljava/awt/AWTEvent;", "public")]
	public Dova.JDK.java.awt.AWTEvent createUngrabEvent(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;IJIIIIIIZI)Ljava/awt/event/MouseEvent;", "public")]
	public Dova.JDK.java.awt.@event.MouseEvent createMouseEvent(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, bool arg9, int arg10)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseEvent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;IIII)Ljava/awt/event/MouseWheelEvent;", "public")]
	public Dova.JDK.java.awt.@event.MouseWheelEvent createMouseWheelEvent(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseWheelEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljdk/swing/interop/LightweightFrameWrapper;)Z", "public")]
	public bool isCompEqual(Dova.JDK.java.awt.Component arg0, Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void notifyDisplayChanged(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightFrameWrapper;IIZ)Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component findComponentAt(Dova.JDK.jdk.swing.interop.LightweightFrameWrapper arg0, int arg1, int arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void setBounds(int arg0, int arg1, int arg2, int arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowFocusListener;)V", "public")]
	public void addWindowFocusListener(Dova.JDK.java.awt.@event.WindowFocusListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/JLightweightFrame;", "private")]
	public Dova.JDK.sun.swing.JLightweightFrame getLightweightFrame()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.JLightweightFrame>(ret);
	}

	[JniSignatureAttribute("(Ljdk/swing/interop/LightweightContentWrapper;)V", "public")]
	public void setContent(Dova.JDK.jdk.swing.interop.LightweightContentWrapper arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(JLjava/lang/Runnable;)V", "")]
	public void overrideNativeWindowHandle(long arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void emulateActivation(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void setHostBounds(int arg0, int arg1, int arg2, int arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}
}
