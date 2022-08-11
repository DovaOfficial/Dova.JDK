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

namespace Dova.JDK.com.sun.java.swing.plaf.motif;

[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;", "public")]
public partial class MotifInternalFrameTitlePane
	: Dova.JDK.javax.swing.plaf.basic.BasicInternalFrameTitlePane
	, Dova.JDK.java.awt.LayoutManager
	, Dova.JDK.java.awt.@event.ActionListener
	, Dova.JDK.java.beans.PropertyChangeListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MotifInternalFrameTitlePane()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "systemButton", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$SystemButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minimizeButton", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MinimizeButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maximizeButton", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MaximizeButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "systemMenu", "Ljavax/swing/JPopupMenu;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "title", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$Title;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "highlight", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shadow", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BUTTON_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "buttonDimension", "Ljava/awt/Dimension;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JInternalFrame;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColors", "(Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSystemMenu", "()Ljavax/swing/JPopupMenu;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getButtonMnemonic", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSubComponents", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assembleSystemMenu", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLayout", "()Ljava/awt/LayoutManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createButtons", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/Action;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$500", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPropertyChangeListener", "()Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showSystemMenu", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hideSystemMenu", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintComponent", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeLayoutComponent", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLayoutComponent", "(Ljava/lang/String;Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutContainer", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$SystemButton;", "")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.SystemButton systemButton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.SystemButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MinimizeButton;", "")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.MinimizeButton minimizeButton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.MinimizeButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MaximizeButton;", "")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.MaximizeButton maximizeButton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.MaximizeButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JPopupMenu;", "")]
	public Dova.JDK.javax.swing.JPopupMenu systemMenu_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JPopupMenu>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$Title;", "")]
	public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.Title title_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.Title>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color color_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color highlight_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "")]
	public Dova.JDK.java.awt.Color shadow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int BUTTON_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Dimension;", "static")]
	public static Dova.JDK.java.awt.Dimension buttonDimension_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MotifInternalFrameTitlePane(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JInternalFrame;)V", "public")]
	public MotifInternalFrameTitlePane(Dova.JDK.javax.swing.JInternalFrame arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V", "")]
	public void setColors(Dova.JDK.java.awt.Color arg0, Dova.JDK.java.awt.Color arg1, Dova.JDK.java.awt.Color arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljavax/swing/JPopupMenu;", "")]
	public Dova.JDK.javax.swing.JPopupMenu getSystemMenu()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JPopupMenu>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "private static")]
	public static int getButtonMnemonic(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void addSubComponents()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void assembleSystemMenu()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()Ljava/awt/LayoutManager;", "protected")]
	public Dova.JDK.java.awt.LayoutManager createLayout()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.LayoutManager>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void createButtons()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;", "static")]
	public static Dova.JDK.javax.swing.JInternalFrame access_000(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/Action;", "static")]
	public static Dova.JDK.javax.swing.Action access_100(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;", "static")]
	public static Dova.JDK.javax.swing.JInternalFrame access_200(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;", "static")]
	public static Dova.JDK.javax.swing.JInternalFrame access_300(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;", "static")]
	public static Dova.JDK.javax.swing.JInternalFrame access_400(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)Ljavax/swing/JInternalFrame;", "static")]
	public static Dova.JDK.javax.swing.JInternalFrame access_500(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JInternalFrame>(ret);
	}

	[JniSignatureAttribute("()Ljava/beans/PropertyChangeListener;", "protected")]
	public Dova.JDK.java.beans.PropertyChangeListener createPropertyChangeListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void showSystemMenu()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void hideSystemMenu()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
	public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void paintComponent(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void removeLayoutComponent(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/Component;)V", "public")]
	public void addLayoutComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.Component arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
	public void layoutContainer(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension preferredLayoutSize(Dova.JDK.java.awt.Container arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension minimumLayoutSize(Dova.JDK.java.awt.Container arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
	public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$SystemButton;", "private")]
	public partial class SystemButton
		: Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.FrameButton
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SystemButton()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$SystemButton;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintComponent", "(Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusTraversable", "()Z"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SystemButton(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)V", "private")]
		public SystemButton(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$SystemButton;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void requestFocus()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
		public void paintComponent(Dova.JDK.java.awt.Graphics arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFocusTraversable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MinimizeButton;", "private")]
	public partial class MinimizeButton
		: Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.FrameButton
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MinimizeButton()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MinimizeButton;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintComponent", "(Ljava/awt/Graphics;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MinimizeButton(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)V", "private")]
		public MinimizeButton(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MinimizeButton;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
		public void paintComponent(Dova.JDK.java.awt.Graphics arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MaximizeButton;", "private")]
	public partial class MaximizeButton
		: Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.FrameButton
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MaximizeButton()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MaximizeButton;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintComponent", "(Ljava/awt/Graphics;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MaximizeButton(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)V", "private")]
		public MaximizeButton(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$MaximizeButton;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
		public void paintComponent(Dova.JDK.java.awt.Graphics arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$Title;", "private")]
	public partial class Title
		: Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane.FrameButton
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Title()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$Title;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardEventToParent", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintComponent", "(Ljava/awt/Graphics;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Title(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;Ljava/lang/String;)V", "")]
		public Title(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$Title;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "")]
		public void forwardEventToParent(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
		public void paintComponent(Dova.JDK.java.awt.Graphics arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$FrameButton;", "private abstract")]
	public partial class FrameButton
		: Dova.JDK.javax.swing.JButton
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FrameButton()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$FrameButton;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintComponent", "(Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusTraversable", "()Z"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FrameButton(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane;)V", "")]
		public FrameButton(Dova.JDK.com.sun.java.swing.plaf.motif.MotifInternalFrameTitlePane arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifInternalFrameTitlePane$FrameButton;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getPreferredSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void requestFocus()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
		public void paintComponent(Dova.JDK.java.awt.Graphics arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getMinimumSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFocusTraversable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}
}
