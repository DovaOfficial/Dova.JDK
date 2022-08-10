/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljava/awt/AWTEventMulticaster;", "public")]
public partial class AWTEventMulticaster
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.@event.ComponentListener
	, Dova.JDK.java.awt.@event.ContainerListener
	, Dova.JDK.java.awt.@event.FocusListener
	, Dova.JDK.java.awt.@event.KeyListener
	, Dova.JDK.java.awt.@event.MouseListener
	, Dova.JDK.java.awt.@event.MouseMotionListener
	, Dova.JDK.java.awt.@event.WindowListener
	, Dova.JDK.java.awt.@event.WindowFocusListener
	, Dova.JDK.java.awt.@event.WindowStateListener
	, Dova.JDK.java.awt.@event.ActionListener
	, Dova.JDK.java.awt.@event.ItemListener
	, Dova.JDK.java.awt.@event.AdjustmentListener
	, Dova.JDK.java.awt.@event.TextListener
	, Dova.JDK.java.awt.@event.InputMethodListener
	, Dova.JDK.java.awt.@event.HierarchyListener
	, Dova.JDK.java.awt.@event.HierarchyBoundsListener
	, Dova.JDK.java.awt.@event.MouseWheelListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AWTEventMulticaster()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/AWTEventMulticaster;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "a", "Ljava/util/EventListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "b", "Ljava/util/EventListener;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AWTEventMulticaster", "(Ljava/util/EventListener;Ljava/util/EventListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/WindowListener;Ljava/awt/event/WindowListener;)Ljava/awt/event/WindowListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/MouseMotionListener;Ljava/awt/event/MouseMotionListener;)Ljava/awt/event/MouseMotionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/MouseListener;Ljava/awt/event/MouseListener;)Ljava/awt/event/MouseListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/WindowStateListener;Ljava/awt/event/WindowStateListener;)Ljava/awt/event/WindowStateListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/WindowFocusListener;Ljava/awt/event/WindowFocusListener;)Ljava/awt/event/WindowFocusListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/ComponentListener;Ljava/awt/event/ComponentListener;)Ljava/awt/event/ComponentListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/ContainerListener;Ljava/awt/event/ContainerListener;)Ljava/awt/event/ContainerListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/FocusListener;Ljava/awt/event/FocusListener;)Ljava/awt/event/FocusListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/KeyListener;Ljava/awt/event/KeyListener;)Ljava/awt/event/KeyListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/InputMethodListener;Ljava/awt/event/InputMethodListener;)Ljava/awt/event/InputMethodListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/HierarchyListener;Ljava/awt/event/HierarchyListener;)Ljava/awt/event/HierarchyListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/HierarchyBoundsListener;Ljava/awt/event/HierarchyBoundsListener;)Ljava/awt/event/HierarchyBoundsListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/MouseWheelListener;Ljava/awt/event/MouseWheelListener;)Ljava/awt/event/MouseWheelListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/ActionListener;Ljava/awt/event/ActionListener;)Ljava/awt/event/ActionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/ItemListener;Ljava/awt/event/ItemListener;)Ljava/awt/event/ItemListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/AdjustmentListener;Ljava/awt/event/AdjustmentListener;)Ljava/awt/event/AdjustmentListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/event/TextListener;Ljava/awt/event/TextListener;)Ljava/awt/event/TextListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remove", "(Ljava/util/EventListener;)Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/WindowListener;Ljava/awt/event/WindowListener;)Ljava/awt/event/WindowListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/MouseMotionListener;Ljava/awt/event/MouseMotionListener;)Ljava/awt/event/MouseMotionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/TextListener;Ljava/awt/event/TextListener;)Ljava/awt/event/TextListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/InputMethodListener;Ljava/awt/event/InputMethodListener;)Ljava/awt/event/InputMethodListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/WindowStateListener;Ljava/awt/event/WindowStateListener;)Ljava/awt/event/WindowStateListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/WindowFocusListener;Ljava/awt/event/WindowFocusListener;)Ljava/awt/event/WindowFocusListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/ActionListener;Ljava/awt/event/ActionListener;)Ljava/awt/event/ActionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/ItemListener;Ljava/awt/event/ItemListener;)Ljava/awt/event/ItemListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/AdjustmentListener;Ljava/awt/event/AdjustmentListener;)Ljava/awt/event/AdjustmentListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/MouseListener;Ljava/awt/event/MouseListener;)Ljava/awt/event/MouseListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/KeyListener;Ljava/awt/event/KeyListener;)Ljava/awt/event/KeyListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/FocusListener;Ljava/awt/event/FocusListener;)Ljava/awt/event/FocusListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/ContainerListener;Ljava/awt/event/ContainerListener;)Ljava/awt/event/ContainerListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/ComponentListener;Ljava/awt/event/ComponentListener;)Ljava/awt/event/ComponentListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/HierarchyBoundsListener;Ljava/awt/event/HierarchyBoundsListener;)Ljava/awt/event/HierarchyBoundsListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/HierarchyListener;Ljava/awt/event/HierarchyListener;)Ljava/awt/event/HierarchyListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/event/MouseWheelListener;Ljava/awt/event/MouseWheelListener;)Ljava/awt/event/MouseWheelListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "save", "(Ljava/io/ObjectOutputStream;Ljava/lang/String;Ljava/util/EventListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getListenerCount", "(Ljava/util/EventListener;Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "adjustmentValueChanged", "(Ljava/awt/event/AdjustmentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "removeInternal", "(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "addInternal", "(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "textValueChanged", "(Ljava/awt/event/TextEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "saveInternal", "(Ljava/io/ObjectOutputStream;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "populateListenerArray", "([Ljava/util/EventListener;Ljava/util/EventListener;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "itemStateChanged", "(Ljava/awt/event/ItemEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getListeners", "(Ljava/util/EventListener;Ljava/lang/Class;)[Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentResized", "(Ljava/awt/event/ComponentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentMoved", "(Ljava/awt/event/ComponentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentShown", "(Ljava/awt/event/ComponentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentHidden", "(Ljava/awt/event/ComponentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "keyTyped", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "keyPressed", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "keyReleased", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mousePressed", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseReleased", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseClicked", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseExited", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseEntered", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseMoved", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseDragged", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseWheelMoved", "(Ljava/awt/event/MouseWheelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inputMethodTextChanged", "(Ljava/awt/event/InputMethodEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "caretPositionChanged", "(Ljava/awt/event/InputMethodEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hierarchyChanged", "(Ljava/awt/event/HierarchyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ancestorMoved", "(Ljava/awt/event/HierarchyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ancestorResized", "(Ljava/awt/event/HierarchyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowOpened", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowClosing", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowClosed", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowIconified", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowDeiconified", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowActivated", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowDeactivated", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowGainedFocus", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowLostFocus", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "windowStateChanged", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentAdded", "(Ljava/awt/event/ContainerEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentRemoved", "(Ljava/awt/event/ContainerEvent;)V"));
	}

	[JniSignatureAttribute("Ljava/util/EventListener;", "protected final")]
	public Dova.JDK.java.util.EventListener a_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/EventListener;", "protected final")]
	public Dova.JDK.java.util.EventListener b_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AWTEventMulticaster(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/util/EventListener;)V", "protected")]
	public AWTEventMulticaster(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.util.EventListener arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/AWTEventMulticaster;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/event/WindowListener;Ljava/awt/event/WindowListener;)Ljava/awt/event/WindowListener;", "public static")]
	public static Dova.JDK.java.awt.@event.WindowListener add(Dova.JDK.java.awt.@event.WindowListener arg0, Dova.JDK.java.awt.@event.WindowListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseMotionListener;Ljava/awt/event/MouseMotionListener;)Ljava/awt/event/MouseMotionListener;", "public static")]
	public static Dova.JDK.java.awt.@event.MouseMotionListener add(Dova.JDK.java.awt.@event.MouseMotionListener arg0, Dova.JDK.java.awt.@event.MouseMotionListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseMotionListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseListener;Ljava/awt/event/MouseListener;)Ljava/awt/event/MouseListener;", "public static")]
	public static Dova.JDK.java.awt.@event.MouseListener add(Dova.JDK.java.awt.@event.MouseListener arg0, Dova.JDK.java.awt.@event.MouseListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowStateListener;Ljava/awt/event/WindowStateListener;)Ljava/awt/event/WindowStateListener;", "public static")]
	public static Dova.JDK.java.awt.@event.WindowStateListener add(Dova.JDK.java.awt.@event.WindowStateListener arg0, Dova.JDK.java.awt.@event.WindowStateListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowStateListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowFocusListener;Ljava/awt/event/WindowFocusListener;)Ljava/awt/event/WindowFocusListener;", "public static")]
	public static Dova.JDK.java.awt.@event.WindowFocusListener add(Dova.JDK.java.awt.@event.WindowFocusListener arg0, Dova.JDK.java.awt.@event.WindowFocusListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowFocusListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentListener;Ljava/awt/event/ComponentListener;)Ljava/awt/event/ComponentListener;", "public static")]
	public static Dova.JDK.java.awt.@event.ComponentListener add(Dova.JDK.java.awt.@event.ComponentListener arg0, Dova.JDK.java.awt.@event.ComponentListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ComponentListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ContainerListener;Ljava/awt/event/ContainerListener;)Ljava/awt/event/ContainerListener;", "public static")]
	public static Dova.JDK.java.awt.@event.ContainerListener add(Dova.JDK.java.awt.@event.ContainerListener arg0, Dova.JDK.java.awt.@event.ContainerListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ContainerListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusListener;Ljava/awt/event/FocusListener;)Ljava/awt/event/FocusListener;", "public static")]
	public static Dova.JDK.java.awt.@event.FocusListener add(Dova.JDK.java.awt.@event.FocusListener arg0, Dova.JDK.java.awt.@event.FocusListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyListener;Ljava/awt/event/KeyListener;)Ljava/awt/event/KeyListener;", "public static")]
	public static Dova.JDK.java.awt.@event.KeyListener add(Dova.JDK.java.awt.@event.KeyListener arg0, Dova.JDK.java.awt.@event.KeyListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.KeyListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/InputMethodListener;Ljava/awt/event/InputMethodListener;)Ljava/awt/event/InputMethodListener;", "public static")]
	public static Dova.JDK.java.awt.@event.InputMethodListener add(Dova.JDK.java.awt.@event.InputMethodListener arg0, Dova.JDK.java.awt.@event.InputMethodListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.InputMethodListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyListener;Ljava/awt/event/HierarchyListener;)Ljava/awt/event/HierarchyListener;", "public static")]
	public static Dova.JDK.java.awt.@event.HierarchyListener add(Dova.JDK.java.awt.@event.HierarchyListener arg0, Dova.JDK.java.awt.@event.HierarchyListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.HierarchyListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyBoundsListener;Ljava/awt/event/HierarchyBoundsListener;)Ljava/awt/event/HierarchyBoundsListener;", "public static")]
	public static Dova.JDK.java.awt.@event.HierarchyBoundsListener add(Dova.JDK.java.awt.@event.HierarchyBoundsListener arg0, Dova.JDK.java.awt.@event.HierarchyBoundsListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.HierarchyBoundsListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseWheelListener;Ljava/awt/event/MouseWheelListener;)Ljava/awt/event/MouseWheelListener;", "public static")]
	public static Dova.JDK.java.awt.@event.MouseWheelListener add(Dova.JDK.java.awt.@event.MouseWheelListener arg0, Dova.JDK.java.awt.@event.MouseWheelListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseWheelListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionListener;Ljava/awt/event/ActionListener;)Ljava/awt/event/ActionListener;", "public static")]
	public static Dova.JDK.java.awt.@event.ActionListener add(Dova.JDK.java.awt.@event.ActionListener arg0, Dova.JDK.java.awt.@event.ActionListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ItemListener;Ljava/awt/event/ItemListener;)Ljava/awt/event/ItemListener;", "public static")]
	public static Dova.JDK.java.awt.@event.ItemListener add(Dova.JDK.java.awt.@event.ItemListener arg0, Dova.JDK.java.awt.@event.ItemListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ItemListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/AdjustmentListener;Ljava/awt/event/AdjustmentListener;)Ljava/awt/event/AdjustmentListener;", "public static")]
	public static Dova.JDK.java.awt.@event.AdjustmentListener add(Dova.JDK.java.awt.@event.AdjustmentListener arg0, Dova.JDK.java.awt.@event.AdjustmentListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.AdjustmentListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/TextListener;Ljava/awt/event/TextListener;)Ljava/awt/event/TextListener;", "public static")]
	public static Dova.JDK.java.awt.@event.TextListener add(Dova.JDK.java.awt.@event.TextListener arg0, Dova.JDK.java.awt.@event.TextListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.TextListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;)Ljava/util/EventListener;", "protected")]
	public Dova.JDK.java.util.EventListener remove(Dova.JDK.java.util.EventListener arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowListener;Ljava/awt/event/WindowListener;)Ljava/awt/event/WindowListener;", "public static")]
	public static Dova.JDK.java.awt.@event.WindowListener remove(Dova.JDK.java.awt.@event.WindowListener arg0, Dova.JDK.java.awt.@event.WindowListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseMotionListener;Ljava/awt/event/MouseMotionListener;)Ljava/awt/event/MouseMotionListener;", "public static")]
	public static Dova.JDK.java.awt.@event.MouseMotionListener remove(Dova.JDK.java.awt.@event.MouseMotionListener arg0, Dova.JDK.java.awt.@event.MouseMotionListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseMotionListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/TextListener;Ljava/awt/event/TextListener;)Ljava/awt/event/TextListener;", "public static")]
	public static Dova.JDK.java.awt.@event.TextListener remove(Dova.JDK.java.awt.@event.TextListener arg0, Dova.JDK.java.awt.@event.TextListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.TextListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/InputMethodListener;Ljava/awt/event/InputMethodListener;)Ljava/awt/event/InputMethodListener;", "public static")]
	public static Dova.JDK.java.awt.@event.InputMethodListener remove(Dova.JDK.java.awt.@event.InputMethodListener arg0, Dova.JDK.java.awt.@event.InputMethodListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.InputMethodListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowStateListener;Ljava/awt/event/WindowStateListener;)Ljava/awt/event/WindowStateListener;", "public static")]
	public static Dova.JDK.java.awt.@event.WindowStateListener remove(Dova.JDK.java.awt.@event.WindowStateListener arg0, Dova.JDK.java.awt.@event.WindowStateListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowStateListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowFocusListener;Ljava/awt/event/WindowFocusListener;)Ljava/awt/event/WindowFocusListener;", "public static")]
	public static Dova.JDK.java.awt.@event.WindowFocusListener remove(Dova.JDK.java.awt.@event.WindowFocusListener arg0, Dova.JDK.java.awt.@event.WindowFocusListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowFocusListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionListener;Ljava/awt/event/ActionListener;)Ljava/awt/event/ActionListener;", "public static")]
	public static Dova.JDK.java.awt.@event.ActionListener remove(Dova.JDK.java.awt.@event.ActionListener arg0, Dova.JDK.java.awt.@event.ActionListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ItemListener;Ljava/awt/event/ItemListener;)Ljava/awt/event/ItemListener;", "public static")]
	public static Dova.JDK.java.awt.@event.ItemListener remove(Dova.JDK.java.awt.@event.ItemListener arg0, Dova.JDK.java.awt.@event.ItemListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ItemListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/AdjustmentListener;Ljava/awt/event/AdjustmentListener;)Ljava/awt/event/AdjustmentListener;", "public static")]
	public static Dova.JDK.java.awt.@event.AdjustmentListener remove(Dova.JDK.java.awt.@event.AdjustmentListener arg0, Dova.JDK.java.awt.@event.AdjustmentListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.AdjustmentListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseListener;Ljava/awt/event/MouseListener;)Ljava/awt/event/MouseListener;", "public static")]
	public static Dova.JDK.java.awt.@event.MouseListener remove(Dova.JDK.java.awt.@event.MouseListener arg0, Dova.JDK.java.awt.@event.MouseListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyListener;Ljava/awt/event/KeyListener;)Ljava/awt/event/KeyListener;", "public static")]
	public static Dova.JDK.java.awt.@event.KeyListener remove(Dova.JDK.java.awt.@event.KeyListener arg0, Dova.JDK.java.awt.@event.KeyListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.KeyListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusListener;Ljava/awt/event/FocusListener;)Ljava/awt/event/FocusListener;", "public static")]
	public static Dova.JDK.java.awt.@event.FocusListener remove(Dova.JDK.java.awt.@event.FocusListener arg0, Dova.JDK.java.awt.@event.FocusListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ContainerListener;Ljava/awt/event/ContainerListener;)Ljava/awt/event/ContainerListener;", "public static")]
	public static Dova.JDK.java.awt.@event.ContainerListener remove(Dova.JDK.java.awt.@event.ContainerListener arg0, Dova.JDK.java.awt.@event.ContainerListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ContainerListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentListener;Ljava/awt/event/ComponentListener;)Ljava/awt/event/ComponentListener;", "public static")]
	public static Dova.JDK.java.awt.@event.ComponentListener remove(Dova.JDK.java.awt.@event.ComponentListener arg0, Dova.JDK.java.awt.@event.ComponentListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ComponentListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyBoundsListener;Ljava/awt/event/HierarchyBoundsListener;)Ljava/awt/event/HierarchyBoundsListener;", "public static")]
	public static Dova.JDK.java.awt.@event.HierarchyBoundsListener remove(Dova.JDK.java.awt.@event.HierarchyBoundsListener arg0, Dova.JDK.java.awt.@event.HierarchyBoundsListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.HierarchyBoundsListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyListener;Ljava/awt/event/HierarchyListener;)Ljava/awt/event/HierarchyListener;", "public static")]
	public static Dova.JDK.java.awt.@event.HierarchyListener remove(Dova.JDK.java.awt.@event.HierarchyListener arg0, Dova.JDK.java.awt.@event.HierarchyListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.HierarchyListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseWheelListener;Ljava/awt/event/MouseWheelListener;)Ljava/awt/event/MouseWheelListener;", "public static")]
	public static Dova.JDK.java.awt.@event.MouseWheelListener remove(Dova.JDK.java.awt.@event.MouseWheelListener arg0, Dova.JDK.java.awt.@event.MouseWheelListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseWheelListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;Ljava/lang/String;Ljava/util/EventListener;)V", "protected static")]
	public static void save(Dova.JDK.java.io.ObjectOutputStream arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.EventListener arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/lang/Class;)I", "private static")]
	public static int getListenerCount(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
	public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/AdjustmentEvent;)V", "public")]
	public void adjustmentValueChanged(Dova.JDK.java.awt.@event.AdjustmentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;", "protected static")]
	public static Dova.JDK.java.util.EventListener removeInternal(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.util.EventListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;", "protected static")]
	public static Dova.JDK.java.util.EventListener addInternal(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.util.EventListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/TextEvent;)V", "public")]
	public void textValueChanged(Dova.JDK.java.awt.@event.TextEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;Ljava/lang/String;)V", "protected")]
	public void saveInternal(Dova.JDK.java.io.ObjectOutputStream arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljava/util/EventListener;Ljava/util/EventListener;I)I", "private static")]
	public static int populateListenerArray(JavaArray<Dova.JDK.java.util.EventListener> arg0, Dova.JDK.java.util.EventListener arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/ItemEvent;)V", "public")]
	public void itemStateChanged(Dova.JDK.java.awt.@event.ItemEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
	public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
	public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/lang/Class;)[Ljava/util/EventListener;", "public static")]
	public static JavaArray<Dova.JDK.java.lang.Object> getListeners(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
	public void componentResized(Dova.JDK.java.awt.@event.ComponentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
	public void componentMoved(Dova.JDK.java.awt.@event.ComponentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
	public void componentShown(Dova.JDK.java.awt.@event.ComponentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
	public void componentHidden(Dova.JDK.java.awt.@event.ComponentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
	public void keyTyped(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
	public void keyPressed(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
	public void keyReleased(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mousePressed(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseReleased(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseClicked(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseExited(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseEntered(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseMoved(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void mouseDragged(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseWheelEvent;)V", "public")]
	public void mouseWheelMoved(Dova.JDK.java.awt.@event.MouseWheelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/InputMethodEvent;)V", "public")]
	public void inputMethodTextChanged(Dova.JDK.java.awt.@event.InputMethodEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/InputMethodEvent;)V", "public")]
	public void caretPositionChanged(Dova.JDK.java.awt.@event.InputMethodEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyEvent;)V", "public")]
	public void hierarchyChanged(Dova.JDK.java.awt.@event.HierarchyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyEvent;)V", "public")]
	public void ancestorMoved(Dova.JDK.java.awt.@event.HierarchyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyEvent;)V", "public")]
	public void ancestorResized(Dova.JDK.java.awt.@event.HierarchyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowOpened(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowClosing(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowClosed(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowIconified(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowDeiconified(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowActivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowDeactivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowGainedFocus(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowLostFocus(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
	public void windowStateChanged(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ContainerEvent;)V", "public")]
	public void componentAdded(Dova.JDK.java.awt.@event.ContainerEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ContainerEvent;)V", "public")]
	public void componentRemoved(Dova.JDK.java.awt.@event.ContainerEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
	}
}
