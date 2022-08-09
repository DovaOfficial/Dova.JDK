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

namespace Dova.JDK.com.sun.java.swing.plaf.motif;

[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;", "public")]
public partial class MotifDesktopIconUI
	: Dova.JDK.javax.swing.plaf.basic.BasicDesktopIconUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MotifDesktopIconUI()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "desktopIconActionListener", "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconActionListener;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "desktopIconMouseListener", "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconMouseListener;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "defaultIcon", "Ljavax/swing/Icon;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "iconButton", "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconButton;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "iconLabel", "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconLabel;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "sysMenuTitlePane", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "systemMenu", "Ljavax/swing/JPopupMenu;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "mml", "Ljava/util/EventListener;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LABEL_HEIGHT", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LABEL_DIVIDER", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "defaultTitleFont", "Ljava/awt/Font;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MotifDesktopIconUI", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDefaultIcon", "(Ljavax/swing/Icon;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createIconButton", "(Ljavax/swing/Icon;)Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconButton;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createIconLabel", "(Ljavax/swing/JInternalFrame;)Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconLabel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createDesktopIconActionListener", "()Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconActionListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createDesktopIconMouseListener", "()Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconMouseListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPreferredSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDefaultIcon", "()Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "uninstallDefaults", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "uninstallComponents", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "showSystemMenu", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hideSystemMenu", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setFrame", "(Ljavax/swing/JInternalFrame;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFrame", "()Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "installDefaults", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "installComponents", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "installListeners", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "uninstallListeners", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDesktopIcon", "()Ljavax/swing/JInternalFrame$JDesktopIcon;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDesktopIcon", "(Ljavax/swing/JInternalFrame$JDesktopIcon;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMaximumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMinimumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconActionListener;", "protected")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.DesktopIconActionListener desktopIconActionListener_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.DesktopIconActionListener>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconMouseListener;", "protected")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.DesktopIconMouseListener desktopIconMouseListener_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.DesktopIconMouseListener>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/Icon;", "protected")]
	public Dova.JDK.javax.swing.Icon defaultIcon_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconButton;", "protected")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.IconButton iconButton_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.IconButton>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconLabel;", "protected")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.IconLabel iconLabel_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.IconLabel>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;", "private")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane sysMenuTitlePane_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/JPopupMenu;", "")]
	public Dova.JDK.javax.swing.JPopupMenu systemMenu_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JPopupMenu>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/EventListener;", "")]
	public Dova.JDK.java.util.EventListener mml_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int LABEL_HEIGHT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("I", "static final")]
	public static int LABEL_DIVIDER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("Ljava/awt/Font;", "static final")]
	public static Dova.JDK.java.awt.Font defaultTitleFont_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MotifDesktopIconUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MotifDesktopIconUI() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/Icon;)V", "public")]
	public void setDefaultIcon(Dova.JDK.javax.swing.Icon arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/Icon;)Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconButton;", "protected")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.IconButton createIconButton(Dova.JDK.javax.swing.Icon arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.IconButton>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JInternalFrame;)Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconLabel;", "protected")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.IconLabel createIconLabel(Dova.JDK.javax.swing.JInternalFrame arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.IconLabel>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconActionListener;", "protected")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.DesktopIconActionListener createDesktopIconActionListener()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.DesktopIconActionListener>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconMouseListener;", "protected")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.DesktopIconMouseListener createDesktopIconMouseListener()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI.DesktopIconMouseListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/Icon;", "public")]
	public Dova.JDK.javax.swing.Icon getDefaultIcon()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallDefaults()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallComponents()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void showSystemMenu()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void hideSystemMenu()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljavax/swing/JInternalFrame;)V", "")]
	public void setFrame(Dova.JDK.javax.swing.JInternalFrame arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/JInternalFrame;", "")]
	public Dova.JDK.javax.swing.JInternalFrame getFrame()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installDefaults()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installComponents()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installListeners()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallListeners()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("()Ljavax/swing/JInternalFrame$JDesktopIcon;", "")]
	public Dova.JDK.javax.swing.JInternalFrame.JDesktopIcon getDesktopIcon()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame.JDesktopIcon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JInternalFrame$JDesktopIcon;)V", "")]
	public void setDesktopIcon(Dova.JDK.javax.swing.JInternalFrame.JDesktopIcon arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMaximumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconButton;", "protected")]
	public partial class IconButton
		: Dova.JDK.javax.swing.JButton
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IconButton()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconButton;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "icon", "Ljavax/swing/Icon;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "IconButton", "(Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;Ljavax/swing/Icon;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "forwardEventToParent", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isFocusTraversable", "()Z"));
		}

		[JniSignatureAttribute("Ljavax/swing/Icon;", "")]
		public Dova.JDK.javax.swing.Icon icon_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IconButton(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;Ljavax/swing/Icon;)V", "")]
		public IconButton(Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI arg0, Dova.JDK.javax.swing.Icon arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconButton;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "")]
		public void forwardEventToParent(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFocusTraversable()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconLabel;", "protected")]
	public partial class IconLabel
		: Dova.JDK.javax.swing.JPanel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IconLabel()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconLabel;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "frame", "Ljavax/swing/JInternalFrame;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "IconLabel", "(Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;Ljavax/swing/JInternalFrame;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "forwardEventToParent", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPreferredSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "paint", "(Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMinimumSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isFocusTraversable", "()Z"));
		}

		[JniSignatureAttribute("Ljavax/swing/JInternalFrame;", "")]
		public Dova.JDK.javax.swing.JInternalFrame frame_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IconLabel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;Ljavax/swing/JInternalFrame;)V", "")]
		public IconLabel(Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI arg0, Dova.JDK.javax.swing.JInternalFrame arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$IconLabel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "")]
		public void forwardEventToParent(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getPreferredSize()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
		public void paint(Dova.JDK.java.awt.Graphics arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getMinimumSize()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFocusTraversable()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconActionListener;", "protected")]
	public partial class DesktopIconActionListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DesktopIconActionListener()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconActionListener;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DesktopIconActionListener", "(Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DesktopIconActionListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;)V", "protected")]
		public DesktopIconActionListener(Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconActionListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconMouseListener;", "protected")]
	public partial class DesktopIconMouseListener
		: Dova.JDK.java.awt.@event.MouseAdapter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DesktopIconMouseListener()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconMouseListener;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DesktopIconMouseListener", "(Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mousePressed", "(Ljava/awt/event/MouseEvent;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DesktopIconMouseListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI;)V", "protected")]
		public DesktopIconMouseListener(Dova.JDK.com.sun.java.swing.plaf.motif.MotifDesktopIconUI arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifDesktopIconUI$DesktopIconMouseListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mousePressed(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}