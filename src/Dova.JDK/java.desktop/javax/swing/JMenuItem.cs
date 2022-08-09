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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "public")]
public partial class JMenuItem
	: Dova.JDK.javax.swing.AbstractButton
	, Dova.JDK.javax.accessibility.Accessible
	, Dova.JDK.javax.swing.MenuElement
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JMenuItem()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/JMenuItem;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "uiClassID", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TRACE", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "VERBOSE", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "isMouseDragged", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "accelerator", "Ljavax/swing/KeyStroke;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JMenuItem", "(Ljava/lang/String;I)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JMenuItem", "(Ljava/lang/String;Ljavax/swing/Icon;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JMenuItem", "(Ljavax/swing/Action;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JMenuItem", "()V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JMenuItem", "(Ljavax/swing/Icon;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JMenuItem", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "init", "(Ljava/lang/String;Ljavax/swing/Icon;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setEnabled", "(Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setAccelerator", "(Ljavax/swing/KeyStroke;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setArmed", "(Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "configurePropertiesFromAction", "(Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setIconFromAction", "(Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "smallIconChanged", "(Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "largeIconChanged", "(Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isArmed", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "actionPropertyChanged", "(Ljavax/swing/Action;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "initFocusability", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "configureAcceleratorFromAction", "(Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "menuSelectionChanged", "(Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSubElements", "()[Ljavax/swing/MenuElement;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "processMenuDragMouseEvent", "(Ljavax/swing/event/MenuDragMouseEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "processMenuKeyEvent", "(Ljavax/swing/event/MenuKeyEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireMenuDragMouseEntered", "(Ljavax/swing/event/MenuDragMouseEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireMenuDragMouseExited", "(Ljavax/swing/event/MenuDragMouseEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireMenuDragMouseDragged", "(Ljavax/swing/event/MenuDragMouseEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireMenuDragMouseReleased", "(Ljavax/swing/event/MenuDragMouseEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireMenuKeyPressed", "(Ljavax/swing/event/MenuKeyEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireMenuKeyReleased", "(Ljavax/swing/event/MenuKeyEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireMenuKeyTyped", "(Ljavax/swing/event/MenuKeyEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAccelerator", "()Ljavax/swing/KeyStroke;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addMenuDragMouseListener", "(Ljavax/swing/event/MenuDragMouseListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeMenuDragMouseListener", "(Ljavax/swing/event/MenuDragMouseListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMenuDragMouseListeners", "()[Ljavax/swing/event/MenuDragMouseListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addMenuKeyListener", "(Ljavax/swing/event/MenuKeyListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeMenuKeyListener", "(Ljavax/swing/event/MenuKeyListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMenuKeyListeners", "()[Ljavax/swing/event/MenuKeyListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "updateUI", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setUI", "(Ljavax/swing/plaf/MenuItemUI;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getUIClassID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getComponent", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "processKeyEvent", "(Ljava/awt/event/KeyEvent;[Ljavax/swing/MenuElement;Ljavax/swing/MenuSelectionManager;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "processMouseEvent", "(Ljava/awt/event/MouseEvent;[Ljavax/swing/MenuElement;Ljavax/swing/MenuSelectionManager;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "alwaysOnTop", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setModel", "(Ljavax/swing/ButtonModel;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String uiClassID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool TRACE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool VERBOSE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isMouseDragged_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("Ljavax/swing/KeyStroke;", "private")]
	public Dova.JDK.javax.swing.KeyStroke accelerator_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JMenuItem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public JMenuItem(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/Icon;)V", "public")]
	public JMenuItem(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.Icon arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "public")]
	public JMenuItem(Dova.JDK.javax.swing.Action arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JMenuItem() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3]))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/Icon;)V", "public")]
	public JMenuItem(Dova.JDK.javax.swing.Icon arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public JMenuItem(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JMenuItem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/Icon;)V", "protected")]
	public void init(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.Icon arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String paramString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setEnabled(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/KeyStroke;)V", "public")]
	public void setAccelerator(Dova.JDK.javax.swing.KeyStroke arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setArmed(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "protected")]
	public void configurePropertiesFromAction(Dova.JDK.javax.swing.Action arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "")]
	public void setIconFromAction(Dova.JDK.javax.swing.Action arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "")]
	public void smallIconChanged(Dova.JDK.javax.swing.Action arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "")]
	public void largeIconChanged(Dova.JDK.javax.swing.Action arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isArmed()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;Ljava/lang/String;)V", "protected")]
	public void actionPropertyChanged(Dova.JDK.javax.swing.Action arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void initFocusability()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "")]
	public void configureAcceleratorFromAction(Dova.JDK.javax.swing.Action arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void menuSelectionChanged(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/MenuElement;", "public")]
	public JavaArray<Dova.JDK.javax.swing.MenuElement> getSubElements()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.MenuElement>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseEvent;)V", "public")]
	public void processMenuDragMouseEvent(Dova.JDK.javax.swing.@event.MenuDragMouseEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuKeyEvent;)V", "public")]
	public void processMenuKeyEvent(Dova.JDK.javax.swing.@event.MenuKeyEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseEvent;)V", "protected")]
	public void fireMenuDragMouseEntered(Dova.JDK.javax.swing.@event.MenuDragMouseEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseEvent;)V", "protected")]
	public void fireMenuDragMouseExited(Dova.JDK.javax.swing.@event.MenuDragMouseEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseEvent;)V", "protected")]
	public void fireMenuDragMouseDragged(Dova.JDK.javax.swing.@event.MenuDragMouseEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseEvent;)V", "protected")]
	public void fireMenuDragMouseReleased(Dova.JDK.javax.swing.@event.MenuDragMouseEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuKeyEvent;)V", "protected")]
	public void fireMenuKeyPressed(Dova.JDK.javax.swing.@event.MenuKeyEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuKeyEvent;)V", "protected")]
	public void fireMenuKeyReleased(Dova.JDK.javax.swing.@event.MenuKeyEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuKeyEvent;)V", "protected")]
	public void fireMenuKeyTyped(Dova.JDK.javax.swing.@event.MenuKeyEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/KeyStroke;", "public")]
	public Dova.JDK.javax.swing.KeyStroke getAccelerator()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseListener;)V", "public")]
	public void addMenuDragMouseListener(Dova.JDK.javax.swing.@event.MenuDragMouseListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuDragMouseListener;)V", "public")]
	public void removeMenuDragMouseListener(Dova.JDK.javax.swing.@event.MenuDragMouseListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/MenuDragMouseListener;", "public")]
	public JavaArray<Dova.JDK.javax.swing.@event.MenuDragMouseListener> getMenuDragMouseListeners()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.MenuDragMouseListener>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuKeyListener;)V", "public")]
	public void addMenuKeyListener(Dova.JDK.javax.swing.@event.MenuKeyListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuKeyListener;)V", "public")]
	public void removeMenuKeyListener(Dova.JDK.javax.swing.@event.MenuKeyListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/MenuKeyListener;", "public")]
	public JavaArray<Dova.JDK.javax.swing.@event.MenuKeyListener> getMenuKeyListeners()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.MenuKeyListener>>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateUI()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33]);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/MenuItemUI;)V", "public")]
	public void setUI(Dova.JDK.javax.swing.plaf.MenuItemUI arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUIClassID()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component getComponent()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;[Ljavax/swing/MenuElement;Ljavax/swing/MenuSelectionManager;)V", "public")]
	public void processKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0, JavaArray<Dova.JDK.javax.swing.MenuElement> arg1, Dova.JDK.javax.swing.MenuSelectionManager arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;[Ljavax/swing/MenuElement;Ljavax/swing/MenuSelectionManager;)V", "public")]
	public void processMouseEvent(Dova.JDK.java.awt.@event.MouseEvent arg0, JavaArray<Dova.JDK.javax.swing.MenuElement> arg1, Dova.JDK.javax.swing.MenuSelectionManager arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool alwaysOnTop()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/ButtonModel;)V", "public")]
	public void setModel(Dova.JDK.javax.swing.ButtonModel arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem$MenuItemFocusListener;", "private static")]
	public partial class MenuItemFocusListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.FocusListener
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MenuItemFocusListener()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/JMenuItem$MenuItemFocusListener;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MenuItemFocusListener", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MenuItemFocusListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public MenuItemFocusListener() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JMenuItem$MenuItemFocusListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem$AccessibleJMenuItem;", "protected")]
	public partial class AccessibleJMenuItem
		: Dova.JDK.javax.swing.AbstractButton.AccessibleAbstractButton
		, Dova.JDK.javax.swing.@event.ChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJMenuItem()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/JMenuItem$AccessibleJMenuItem;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "isArmed", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "hasFocus", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "isPressed", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "isSelected", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljavax/swing/JMenuItem;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AccessibleJMenuItem", "(Ljavax/swing/JMenuItem;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireAccessibilityFocusedEvent", "(Ljavax/swing/JMenuItem;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isArmed_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool hasFocus_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isPressed_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isSelected_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "final")]
		public Dova.JDK.javax.swing.JMenuItem this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJMenuItem(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JMenuItem;)V", "")]
		public AccessibleJMenuItem(Dova.JDK.javax.swing.JMenuItem arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JMenuItem$AccessibleJMenuItem;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JMenuItem;)V", "private")]
		public void fireAccessibilityFocusedEvent(Dova.JDK.javax.swing.JMenuItem arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}
}