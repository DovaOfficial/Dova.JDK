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

namespace Dova.JDK.com.sun.java.accessibility.util;

[JniSignatureAttribute("Lcom/sun/java/accessibility/util/AWTEventMonitor;", "public")]
public partial class AWTEventMonitor
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AWTEventMonitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/accessibility/util/AWTEventMonitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "componentWithFocus", "Ljava/awt/Component;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "componentListener", "Ljava/awt/event/ComponentListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "containerListener", "Ljava/awt/event/ContainerListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "focusListener", "Ljava/awt/event/FocusListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "keyListener", "Ljava/awt/event/KeyListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mouseListener", "Ljava/awt/event/MouseListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mouseMotionListener", "Ljava/awt/event/MouseMotionListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "windowListener", "Ljava/awt/event/WindowListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "actionListener", "Ljava/awt/event/ActionListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "adjustmentListener", "Ljava/awt/event/AdjustmentListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "itemListener", "Ljava/awt/event/ItemListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "textListener", "Ljava/awt/event/TextListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "awtListener", "Lcom/sun/java/accessibility/util/AWTEventMonitor$AWTEventsListener;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addWindowListener", "(Ljava/awt/event/WindowListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addActionListener", "(Ljava/awt/event/ActionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkInstallPermission", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getComponentWithFocus", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeWindowListener", "(Ljava/awt/event/WindowListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addTextListener", "(Ljava/awt/event/TextListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeTextListener", "(Ljava/awt/event/TextListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addComponentListener", "(Ljava/awt/event/ComponentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addFocusListener", "(Ljava/awt/event/FocusListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addKeyListener", "(Ljava/awt/event/KeyListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addMouseListener", "(Ljava/awt/event/MouseListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addMouseMotionListener", "(Ljava/awt/event/MouseMotionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeComponentListener", "(Ljava/awt/event/ComponentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeFocusListener", "(Ljava/awt/event/FocusListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeKeyListener", "(Ljava/awt/event/KeyListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeMouseListener", "(Ljava/awt/event/MouseListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeMouseMotionListener", "(Ljava/awt/event/MouseMotionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addContainerListener", "(Ljava/awt/event/ContainerListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeContainerListener", "(Ljava/awt/event/ContainerListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeActionListener", "(Ljava/awt/event/ActionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeItemListener", "(Ljava/awt/event/ItemListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addItemListener", "(Ljava/awt/event/ItemListener;)V"));
	}

	[JniSignatureAttribute("Ljava/awt/Component;", "private static")]
	public static Dova.JDK.java.awt.Component componentWithFocus_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ComponentListener;", "private static")]
	public static Dova.JDK.java.awt.@event.ComponentListener componentListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ComponentListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ContainerListener;", "private static")]
	public static Dova.JDK.java.awt.@event.ContainerListener containerListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ContainerListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/FocusListener;", "private static")]
	public static Dova.JDK.java.awt.@event.FocusListener focusListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/KeyListener;", "private static")]
	public static Dova.JDK.java.awt.@event.KeyListener keyListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.KeyListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/MouseListener;", "private static")]
	public static Dova.JDK.java.awt.@event.MouseListener mouseListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/MouseMotionListener;", "private static")]
	public static Dova.JDK.java.awt.@event.MouseMotionListener mouseMotionListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseMotionListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/WindowListener;", "private static")]
	public static Dova.JDK.java.awt.@event.WindowListener windowListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ActionListener;", "private static")]
	public static Dova.JDK.java.awt.@event.ActionListener actionListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/AdjustmentListener;", "private static")]
	public static Dova.JDK.java.awt.@event.AdjustmentListener adjustmentListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.AdjustmentListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ItemListener;", "private static")]
	public static Dova.JDK.java.awt.@event.ItemListener itemListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ItemListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/TextListener;", "private static")]
	public static Dova.JDK.java.awt.@event.TextListener textListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.TextListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/accessibility/util/AWTEventMonitor$AWTEventsListener;", "private static final")]
	public static Dova.JDK.com.sun.java.accessibility.util.AWTEventMonitor.AWTEventsListener awtListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.accessibility.util.AWTEventMonitor.AWTEventsListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AWTEventMonitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AWTEventMonitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/accessibility/util/AWTEventMonitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/event/WindowListener;)V", "public static")]
	public static void addWindowListener(Dova.JDK.java.awt.@event.WindowListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionListener;)V", "public static")]
	public static void addActionListener(Dova.JDK.java.awt.@event.ActionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void checkInstallPermission()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public static")]
	public static Dova.JDK.java.awt.Component getComponentWithFocus()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowListener;)V", "public static")]
	public static void removeWindowListener(Dova.JDK.java.awt.@event.WindowListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/AdjustmentListener;)V", "public static")]
	public static void addAdjustmentListener(Dova.JDK.java.awt.@event.AdjustmentListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/AdjustmentListener;)V", "public static")]
	public static void removeAdjustmentListener(Dova.JDK.java.awt.@event.AdjustmentListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/TextListener;)V", "public static")]
	public static void addTextListener(Dova.JDK.java.awt.@event.TextListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/TextListener;)V", "public static")]
	public static void removeTextListener(Dova.JDK.java.awt.@event.TextListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentListener;)V", "public static")]
	public static void addComponentListener(Dova.JDK.java.awt.@event.ComponentListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public static")]
	public static void addFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyListener;)V", "public static")]
	public static void addKeyListener(Dova.JDK.java.awt.@event.KeyListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseListener;)V", "public static")]
	public static void addMouseListener(Dova.JDK.java.awt.@event.MouseListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseMotionListener;)V", "public static")]
	public static void addMouseMotionListener(Dova.JDK.java.awt.@event.MouseMotionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentListener;)V", "public static")]
	public static void removeComponentListener(Dova.JDK.java.awt.@event.ComponentListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public static")]
	public static void removeFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyListener;)V", "public static")]
	public static void removeKeyListener(Dova.JDK.java.awt.@event.KeyListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseListener;)V", "public static")]
	public static void removeMouseListener(Dova.JDK.java.awt.@event.MouseListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseMotionListener;)V", "public static")]
	public static void removeMouseMotionListener(Dova.JDK.java.awt.@event.MouseMotionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ContainerListener;)V", "public static")]
	public static void addContainerListener(Dova.JDK.java.awt.@event.ContainerListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ContainerListener;)V", "public static")]
	public static void removeContainerListener(Dova.JDK.java.awt.@event.ContainerListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionListener;)V", "public static")]
	public static void removeActionListener(Dova.JDK.java.awt.@event.ActionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ItemListener;)V", "public static")]
	public static void removeItemListener(Dova.JDK.java.awt.@event.ItemListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ItemListener;)V", "public static")]
	public static void addItemListener(Dova.JDK.java.awt.@event.ItemListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/java/accessibility/util/AWTEventMonitor$AWTEventsListener;", "static")]
	public partial class AWTEventsListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.java.accessibility.util.TopLevelWindowListener
		, Dova.JDK.java.awt.@event.ActionListener
		, Dova.JDK.java.awt.@event.AdjustmentListener
		, Dova.JDK.java.awt.@event.ComponentListener
		, Dova.JDK.java.awt.@event.ContainerListener
		, Dova.JDK.java.awt.@event.FocusListener
		, Dova.JDK.java.awt.@event.ItemListener
		, Dova.JDK.java.awt.@event.KeyListener
		, Dova.JDK.java.awt.@event.MouseListener
		, Dova.JDK.java.awt.@event.MouseMotionListener
		, Dova.JDK.java.awt.@event.TextListener
		, Dova.JDK.java.awt.@event.WindowListener
		, Dova.JDK.javax.swing.@event.ChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AWTEventsListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/accessibility/util/AWTEventMonitor$AWTEventsListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actionListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeActionMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addActionMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actionArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "itemListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeItemMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addItemMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "itemArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeTextMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addTextMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "windowListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeWindowMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addWindowMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "windowArgs", "[Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "(Ljava/awt/Component;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeListeners", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeListeners", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeListeners", "(Ljava/awt/Component;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustmentValueChanged", "(Ljava/awt/event/AdjustmentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeIntrospection", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processFocusGained", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "textValueChanged", "(Ljava/awt/event/TextEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "topLevelWindowCreated", "(Ljava/awt/Window;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "topLevelWindowDestroyed", "(Ljava/awt/Window;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowOpened", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowClosing", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowClosed", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowIconified", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowDeiconified", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowActivated", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowDeactivated", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentResized", "(Ljava/awt/event/ComponentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentMoved", "(Ljava/awt/event/ComponentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentShown", "(Ljava/awt/event/ComponentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentHidden", "(Ljava/awt/event/ComponentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "keyTyped", "(Ljava/awt/event/KeyEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "keyPressed", "(Ljava/awt/event/KeyEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "keyReleased", "(Ljava/awt/event/KeyEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mousePressed", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseReleased", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseClicked", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseExited", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseEntered", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseMoved", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseDragged", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentAdded", "(Ljava/awt/event/ContainerEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentRemoved", "(Ljava/awt/event/ContainerEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemStateChanged", "(Ljava/awt/event/ItemEvent;)V"));
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> actionListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeActionMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addActionMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> actionArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> itemListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeItemMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addItemMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> itemArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> textListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeTextMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addTextMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> textArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> windowListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeWindowMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addWindowMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> windowArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AWTEventsListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AWTEventsListener() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/accessibility/util/AWTEventMonitor$AWTEventsListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;I)V", "protected")]
		public void installListeners(Dova.JDK.java.awt.Component arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "protected")]
		public void installListeners(Dova.JDK.java.awt.Component arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(I)V", "protected")]
		public void installListeners(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void installListeners()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("(I)V", "protected")]
		public void removeListeners(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "protected")]
		public void removeListeners(Dova.JDK.java.awt.Component arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;I)V", "protected")]
		public void removeListeners(Dova.JDK.java.awt.Component arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/event/AdjustmentEvent;)V", "public")]
		public void adjustmentValueChanged(Dova.JDK.java.awt.@event.AdjustmentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool initializeIntrospection()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void processFocusGained()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
		}

		[JniSignatureAttribute("(Ljava/awt/event/TextEvent;)V", "public")]
		public void textValueChanged(Dova.JDK.java.awt.@event.TextEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)V", "public")]
		public void topLevelWindowCreated(Dova.JDK.java.awt.Window arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Window;)V", "public")]
		public void topLevelWindowDestroyed(Dova.JDK.java.awt.Window arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowOpened(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowClosing(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowClosed(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowIconified(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowDeiconified(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowActivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowDeactivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentResized(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentMoved(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentShown(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentHidden(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
		public void keyTyped(Dova.JDK.java.awt.@event.KeyEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
		public void keyPressed(Dova.JDK.java.awt.@event.KeyEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
		public void keyReleased(Dova.JDK.java.awt.@event.KeyEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mousePressed(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseReleased(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseClicked(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseExited(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseEntered(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseMoved(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseDragged(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ContainerEvent;)V", "public")]
		public void componentAdded(Dova.JDK.java.awt.@event.ContainerEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ContainerEvent;)V", "public")]
		public void componentRemoved(Dova.JDK.java.awt.@event.ContainerEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ItemEvent;)V", "public")]
		public void itemStateChanged(Dova.JDK.java.awt.@event.ItemEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		}
	}
}
