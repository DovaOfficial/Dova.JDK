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

namespace Dova.JDK.javax.swing.plaf.metal;

[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane;", "")]
public partial class MetalTitlePane
	: Dova.JDK.javax.swing.JComponent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MetalTitlePane()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTitlePane;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "handyEmptyBorder", "Ljavax/swing/border/Border;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMAGE_HEIGHT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMAGE_WIDTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyChangeListener", "Ljava/beans/PropertyChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "menuBar", "Ljavax/swing/JMenuBar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closeAction", "Ljavax/swing/Action;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iconifyAction", "Ljavax/swing/Action;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "restoreAction", "Ljavax/swing/Action;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maximizeAction", "Ljavax/swing/Action;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toggleButton", "Ljavax/swing/JButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iconifyButton", "Ljavax/swing/JButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closeButton", "Ljavax/swing/JButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maximizeIcon", "Ljavax/swing/Icon;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minimizeIcon", "Ljavax/swing/Icon;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "systemIcon", "Ljava/awt/Image;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "windowListener", "Ljava/awt/event/WindowListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "window", "Ljava/awt/Window;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootPane", "Ljavax/swing/JRootPane;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buttonsWidth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootPaneUI", "Ljavax/swing/plaf/metal/MetalRootPaneUI;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inactiveBackground", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inactiveForeground", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inactiveShadow", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeBumpsHighlight", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeBumpsShadow", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeBackground", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeForeground", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeShadow", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeBumps", "Ljavax/swing/plaf/metal/MetalBumps;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inactiveBumps", "Ljavax/swing/plaf/metal/MetalBumps;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JRootPane;Ljavax/swing/plaf/metal/MetalRootPaneUI;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setState", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setState", "(IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstall", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restore", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maximize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMenu", "()Ljavax/swing/JMenu;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintComponent", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installSubcomponents", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "determineColors", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLayout", "()Ljava/awt/LayoutManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createWindowListener", "()Ljava/awt/event/WindowListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createWindowPropertyChangeListener", "()Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateSystemIcon", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createActions", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMenuItems", "(Ljavax/swing/JMenu;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTitleButton", "()Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateToggleButton", "(Ljavax/swing/Action;Ljavax/swing/Icon;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iconify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createButtons", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindowDecorationStyle", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setActive", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindow", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrame", "()Ljava/awt/Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootPane", "()Ljavax/swing/JRootPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTitle", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMenuBar", "()Ljavax/swing/JMenuBar;"));
	}

	[JniSignatureAttribute("Ljavax/swing/border/Border;", "private static final")]
	public static Dova.JDK.javax.swing.border.Border handyEmptyBorder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int IMAGE_HEIGHT_Property
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
	public static int IMAGE_WIDTH_Property
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

	[JniSignatureAttribute("Ljava/beans/PropertyChangeListener;", "private")]
	public Dova.JDK.java.beans.PropertyChangeListener propertyChangeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuBar;", "private")]
	public Dova.JDK.javax.swing.JMenuBar menuBar_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuBar>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Action;", "private")]
	public Dova.JDK.javax.swing.Action closeAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Action;", "private")]
	public Dova.JDK.javax.swing.Action iconifyAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Action;", "private")]
	public Dova.JDK.javax.swing.Action restoreAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Action;", "private")]
	public Dova.JDK.javax.swing.Action maximizeAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JButton;", "private")]
	public Dova.JDK.javax.swing.JButton toggleButton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JButton;", "private")]
	public Dova.JDK.javax.swing.JButton iconifyButton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JButton;", "private")]
	public Dova.JDK.javax.swing.JButton closeButton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon maximizeIcon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon minimizeIcon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Image;", "private")]
	public Dova.JDK.java.awt.Image systemIcon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/WindowListener;", "private")]
	public Dova.JDK.java.awt.@event.WindowListener windowListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Window;", "private")]
	public Dova.JDK.java.awt.Window window_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JRootPane;", "private")]
	public Dova.JDK.javax.swing.JRootPane rootPane_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRootPane>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int buttonsWidth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalRootPaneUI;", "private")]
	public Dova.JDK.javax.swing.plaf.metal.MetalRootPaneUI rootPaneUI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalRootPaneUI>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color inactiveBackground_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color inactiveForeground_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color inactiveShadow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color activeBumpsHighlight_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color activeBumpsShadow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color activeBackground_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color activeForeground_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color activeShadow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalBumps;", "private")]
	public Dova.JDK.javax.swing.plaf.metal.MetalBumps activeBumps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalBumps>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalBumps;", "private")]
	public Dova.JDK.javax.swing.plaf.metal.MetalBumps inactiveBumps_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalBumps>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MetalTitlePane(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JRootPane;Ljavax/swing/plaf/metal/MetalRootPaneUI;)V", "public")]
	public MetalTitlePane(Dova.JDK.javax.swing.JRootPane arg0, Dova.JDK.javax.swing.plaf.metal.MetalRootPaneUI arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTitlePane;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "private")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void setState(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(IZ)V", "private")]
	public void setState(int arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void uninstall()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void restore()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void maximize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()Ljavax/swing/JMenu;", "private")]
	public Dova.JDK.javax.swing.JMenu createMenu()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenu>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void paintComponent(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void installSubcomponents()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void determineColors()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()Ljava/awt/LayoutManager;", "private")]
	public Dova.JDK.java.awt.LayoutManager createLayout()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.LayoutManager>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/event/WindowListener;", "private")]
	public Dova.JDK.java.awt.@event.WindowListener createWindowListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.WindowListener>(ret);
	}

	[JniSignatureAttribute("()Ljava/beans/PropertyChangeListener;", "private")]
	public Dova.JDK.java.beans.PropertyChangeListener createWindowPropertyChangeListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void updateSystemIcon()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void createActions()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("(Ljavax/swing/JMenu;)V", "private")]
	public void addMenuItems(Dova.JDK.javax.swing.JMenu arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/JButton;", "private")]
	public Dova.JDK.javax.swing.JButton createTitleButton()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;Ljavax/swing/Icon;)V", "private")]
	public void updateToggleButton(Dova.JDK.javax.swing.Action arg0, Dova.JDK.javax.swing.Icon arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void iconify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void createButtons()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("()I", "private")]
	public int getWindowDecorationStyle()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void installDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void uninstallDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void installListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void uninstallListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void setActive(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Window;", "private")]
	public Dova.JDK.java.awt.Window getWindow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void addNotify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void removeNotify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28]);
	}

	[JniSignatureAttribute("()Ljava/awt/Frame;", "private")]
	public Dova.JDK.java.awt.Frame getFrame()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Frame>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JRootPane;", "public")]
	public Dova.JDK.javax.swing.JRootPane getRootPane()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRootPane>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getTitle()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JMenuBar;", "protected")]
	public Dova.JDK.javax.swing.JMenuBar createMenuBar()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuBar>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane$WindowHandler;", "private")]
	public partial class WindowHandler
		: Dova.JDK.java.awt.@event.WindowAdapter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WindowHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTitlePane$WindowHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowActivated", "(Ljava/awt/event/WindowEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "windowDeactivated", "(Ljava/awt/event/WindowEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WindowHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalTitlePane;)V", "private")]
		public WindowHandler(Dova.JDK.javax.swing.plaf.metal.MetalTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTitlePane$WindowHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowActivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "public")]
		public void windowDeactivated(Dova.JDK.java.awt.@event.WindowEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane$PropertyChangeHandler;", "private")]
	public partial class PropertyChangeHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.beans.PropertyChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PropertyChangeHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTitlePane$PropertyChangeHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PropertyChangeHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalTitlePane;)V", "private")]
		public PropertyChangeHandler(Dova.JDK.javax.swing.plaf.metal.MetalTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTitlePane$PropertyChangeHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane$SystemMenuBar;", "private")]
	public partial class SystemMenuBar
		: Dova.JDK.javax.swing.JMenuBar
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SystemMenuBar()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTitlePane$SystemMenuBar;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "()Ljava/awt/Dimension;"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SystemMenuBar(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalTitlePane;)V", "private")]
		public SystemMenuBar(Dova.JDK.javax.swing.plaf.metal.MetalTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTitlePane$SystemMenuBar;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
		public void paint(Dova.JDK.java.awt.Graphics arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getPreferredSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getMinimumSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane$CloseAction;", "private")]
	public partial class CloseAction
		: Dova.JDK.javax.swing.AbstractAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CloseAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTitlePane$CloseAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CloseAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalTitlePane;)V", "public")]
		public CloseAction(Dova.JDK.javax.swing.plaf.metal.MetalTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTitlePane$CloseAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane$IconifyAction;", "private")]
	public partial class IconifyAction
		: Dova.JDK.javax.swing.AbstractAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IconifyAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTitlePane$IconifyAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IconifyAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalTitlePane;)V", "public")]
		public IconifyAction(Dova.JDK.javax.swing.plaf.metal.MetalTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTitlePane$IconifyAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane$RestoreAction;", "private")]
	public partial class RestoreAction
		: Dova.JDK.javax.swing.AbstractAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RestoreAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTitlePane$RestoreAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RestoreAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalTitlePane;)V", "public")]
		public RestoreAction(Dova.JDK.javax.swing.plaf.metal.MetalTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTitlePane$RestoreAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane$MaximizeAction;", "private")]
	public partial class MaximizeAction
		: Dova.JDK.javax.swing.AbstractAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MaximizeAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTitlePane$MaximizeAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MaximizeAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalTitlePane;)V", "public")]
		public MaximizeAction(Dova.JDK.javax.swing.plaf.metal.MetalTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTitlePane$MaximizeAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane$TitlePaneLayout;", "private")]
	public partial class TitlePaneLayout
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.LayoutManager
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TitlePaneLayout()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTitlePane$TitlePaneLayout;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeHeight", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeLayoutComponent", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLayoutComponent", "(Ljava/lang/String;Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutContainer", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTitlePane;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TitlePaneLayout(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalTitlePane;)V", "private")]
		public TitlePaneLayout(Dova.JDK.javax.swing.plaf.metal.MetalTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTitlePane$TitlePaneLayout;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "private")]
		public int computeHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
		public void removeLayoutComponent(Dova.JDK.java.awt.Component arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/Component;)V", "public")]
		public void addLayoutComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.Component arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
		public void layoutContainer(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension preferredLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension minimumLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}
	}
}
