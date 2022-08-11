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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/JDialog;", "public")]
public partial class JDialog
	: Dova.JDK.java.awt.Dialog
	, Dova.JDK.javax.swing.WindowConstants
	, Dova.JDK.javax.accessibility.Accessible
	, Dova.JDK.javax.swing.RootPaneContainer
	, Dova.JDK.javax.swing.TransferHandler.HasGetTransferHandler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JDialog()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JDialog;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultLookAndFeelDecoratedKey", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultCloseOperation", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootPane", "Ljavax/swing/JRootPane;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootPaneCheckingEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transferHandler", "Ljavax/swing/TransferHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessibleContext", "Ljavax/accessibility/AccessibleContext;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Window;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dialog;Ljava/lang/String;ZLjava/awt/GraphicsConfiguration;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dialog;Ljava/lang/String;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dialog;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Window;Ljava/lang/String;Ljava/awt/Dialog$ModalityType;Ljava/awt/GraphicsConfiguration;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Window;Ljava/lang/String;Ljava/awt/Dialog$ModalityType;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Window;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Window;Ljava/awt/Dialog$ModalityType;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Frame;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Frame;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Frame;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dialog;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dialog;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Frame;Ljava/lang/String;ZLjava/awt/GraphicsConfiguration;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Frame;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlassPane", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLayeredPane", "(Ljavax/swing/JLayeredPane;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContentPane", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setJMenuBar", "(Ljavax/swing/JMenuBar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJMenuBar", "()Ljavax/swing/JMenuBar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlassPane", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTransferHandler", "(Ljavax/swing/TransferHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransferHandler", "()Ljavax/swing/TransferHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDefaultLookAndFeelDecorated", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dialogInit", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createRootPane", "()Ljavax/swing/JRootPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRootPane", "(Ljavax/swing/JRootPane;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRootPaneCheckingEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRootPaneCheckingEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultCloseOperation", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultCloseOperation", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setDefaultLookAndFeelDecorated", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphics", "()Ljava/awt/Graphics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repaint", "(JIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLayout", "(Ljava/awt/LayoutManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processWindowEvent", "(Ljava/awt/event/WindowEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootPane", "()Ljavax/swing/JRootPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayeredPane", "()Ljavax/swing/JLayeredPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContentPane", "()Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addImpl", "(Ljava/awt/Component;Ljava/lang/Object;I)V"));
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object defaultLookAndFeelDecoratedKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int defaultCloseOperation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JRootPane;", "protected")]
	public Dova.JDK.javax.swing.JRootPane rootPane_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRootPane>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool rootPaneCheckingEnabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/TransferHandler;", "private")]
	public Dova.JDK.javax.swing.TransferHandler transferHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.TransferHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/accessibility/AccessibleContext;", "protected")]
	public Dova.JDK.javax.accessibility.AccessibleContext accessibleContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JDialog(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Window arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;Ljava/lang/String;ZLjava/awt/GraphicsConfiguration;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Dialog arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.awt.GraphicsConfiguration arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;Ljava/lang/String;Z)V", "public")]
	public JDialog(Dova.JDK.java.awt.Dialog arg0, Dova.JDK.java.lang.String arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;Ljava/lang/String;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Dialog arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Window;Ljava/lang/String;Ljava/awt/Dialog$ModalityType;Ljava/awt/GraphicsConfiguration;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Window arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.awt.Dialog.ModalityType arg2, Dova.JDK.java.awt.GraphicsConfiguration arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Window;Ljava/lang/String;Ljava/awt/Dialog$ModalityType;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Window arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.awt.Dialog.ModalityType arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Window;Ljava/lang/String;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Window arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Window;Ljava/awt/Dialog$ModalityType;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Window arg0, Dova.JDK.java.awt.Dialog.ModalityType arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[7], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Frame;Ljava/lang/String;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Frame arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[8], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Frame;Z)V", "public")]
	public JDialog(Dova.JDK.java.awt.Frame arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[9], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Frame;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Frame arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[10], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JDialog() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[11]))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;Z)V", "public")]
	public JDialog(Dova.JDK.java.awt.Dialog arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[12], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Dialog;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Dialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[13], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Frame;Ljava/lang/String;ZLjava/awt/GraphicsConfiguration;)V", "public")]
	public JDialog(Dova.JDK.java.awt.Frame arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.awt.GraphicsConfiguration arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[14], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Frame;Ljava/lang/String;Z)V", "public")]
	public JDialog(Dova.JDK.java.awt.Frame arg0, Dova.JDK.java.lang.String arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[15], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JDialog;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void remove(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void update(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String paramString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void setGlassPane(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JLayeredPane;)V", "public")]
	public void setLayeredPane(Dova.JDK.javax.swing.JLayeredPane arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
	public void setContentPane(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JMenuBar;)V", "public")]
	public void setJMenuBar(Dova.JDK.javax.swing.JMenuBar arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/JMenuBar;", "public")]
	public Dova.JDK.javax.swing.JMenuBar getJMenuBar()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuBar>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component getGlassPane()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/TransferHandler;)V", "public")]
	public void setTransferHandler(Dova.JDK.javax.swing.TransferHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/TransferHandler;", "public")]
	public Dova.JDK.javax.swing.TransferHandler getTransferHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.TransferHandler>(ret);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDefaultLookAndFeelDecorated()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void dialogInit()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()Ljavax/swing/JRootPane;", "protected")]
	public Dova.JDK.javax.swing.JRootPane createRootPane()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRootPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JRootPane;)V", "protected")]
	public void setRootPane(Dova.JDK.javax.swing.JRootPane arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void setRootPaneCheckingEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isRootPaneCheckingEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setDefaultCloseOperation(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDefaultCloseOperation()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public static")]
	public static void setDefaultLookAndFeelDecorated(bool arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Graphics;", "public")]
	public Dova.JDK.java.awt.Graphics getGraphics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics>(ret);
	}

	[JniSignatureAttribute("(JIIII)V", "public")]
	public void repaint(long arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/LayoutManager;)V", "public")]
	public void setLayout(Dova.JDK.java.awt.LayoutManager arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/WindowEvent;)V", "protected")]
	public void processWindowEvent(Dova.JDK.java.awt.@event.WindowEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/JRootPane;", "public")]
	public Dova.JDK.javax.swing.JRootPane getRootPane()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRootPane>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JLayeredPane;", "public")]
	public Dova.JDK.javax.swing.JLayeredPane getLayeredPane()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLayeredPane>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Container;", "public")]
	public Dova.JDK.java.awt.Container getContentPane()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/lang/Object;I)V", "protected")]
	public void addImpl(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Ljavax/swing/JDialog$AccessibleJDialog;", "protected")]
	public partial class AccessibleJDialog
		: Dova.JDK.java.awt.Dialog.AccessibleAWTDialog
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJDialog()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JDialog$AccessibleJDialog;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
		}

		[JniSignatureAttribute("Ljavax/swing/JDialog;", "final")]
		public Dova.JDK.javax.swing.JDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJDialog(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JDialog;)V", "protected")]
		public AccessibleJDialog(Dova.JDK.javax.swing.JDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JDialog$AccessibleJDialog;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getAccessibleName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
		}
	}
}
