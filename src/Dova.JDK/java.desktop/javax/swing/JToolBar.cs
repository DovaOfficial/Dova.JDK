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

[JniSignatureAttribute("Ljavax/swing/JToolBar;", "public")]
public partial class JToolBar
	: Dova.JDK.javax.swing.JComponent
	, Dova.JDK.javax.swing.SwingConstants
	, Dova.JDK.javax.accessibility.Accessible
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JToolBar()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JToolBar;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "uiClassID", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paintBorder", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "margin", "Ljava/awt/Insets;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "floatable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "orientation", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljavax/swing/Action;)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOrientation", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkOrientation", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFloatable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFloatable", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBorder", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClassID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_0", "()Ljavax/swing/plaf/ToolBarUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_1", "()Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUI", "(Ljavax/swing/plaf/ToolBarUI;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createActionComponent", "(Ljavax/swing/Action;)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentIndex", "(Ljava/awt/Component;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBorderPainted", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createActionChangeListener", "(Ljavax/swing/JButton;)Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentAtIndex", "(I)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBorderPainted", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMargin", "()Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRollover", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRollover", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMargin", "(Ljava/awt/Insets;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSeparator", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSeparator", "(Ljava/awt/Dimension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLayout", "(Ljava/awt/LayoutManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrientation", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addImpl", "(Ljava/awt/Component;Ljava/lang/Object;I)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String uiClassID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool paintBorder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "private")]
	public Dova.JDK.java.awt.Insets margin_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool floatable_Property
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

	[JniSignatureAttribute("I", "private")]
	public int orientation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JToolBar(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public JToolBar(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public JToolBar(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public JToolBar(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JToolBar() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JToolBar;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/Action;)Ljavax/swing/JButton;", "public")]
	public Dova.JDK.javax.swing.JButton add(Dova.JDK.javax.swing.Action arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String paramString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setOrientation(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void checkOrientation(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFloatable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setFloatable(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "protected")]
	public void paintBorder(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUIClassID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateUI()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ToolBarUI;", "public")]
	public Dova.JDK.javax.swing.plaf.ToolBarUI getUI_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ToolBarUI>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ComponentUI;", "public volatile")]
	public Dova.JDK.javax.swing.plaf.ComponentUI getUI_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/ToolBarUI;)V", "public")]
	public void setUI(Dova.JDK.javax.swing.plaf.ToolBarUI arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)Ljavax/swing/JButton;", "protected")]
	public Dova.JDK.javax.swing.JButton createActionComponent(Dova.JDK.javax.swing.Action arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)I", "public")]
	public int getComponentIndex(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isBorderPainted()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JButton;)Ljava/beans/PropertyChangeListener;", "protected")]
	public Dova.JDK.java.beans.PropertyChangeListener createActionChangeListener(Dova.JDK.javax.swing.JButton arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component getComponentAtIndex(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setBorderPainted(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Insets;", "public")]
	public Dova.JDK.java.awt.Insets getMargin()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRollover()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setRollover(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Insets;)V", "public")]
	public void setMargin(Dova.JDK.java.awt.Insets arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void addSeparator()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
	public void addSeparator(Dova.JDK.java.awt.Dimension arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/LayoutManager;)V", "public")]
	public void setLayout(Dova.JDK.java.awt.LayoutManager arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getOrientation()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/lang/Object;I)V", "protected")]
	public void addImpl(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Ljavax/swing/JToolBar$DefaultToolBarLayout;", "private")]
	public partial class DefaultToolBarLayout
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.LayoutManager2
		, Dova.JDK.java.io.Serializable
		, Dova.JDK.java.beans.PropertyChangeListener
		, Dova.JDK.javax.swing.plaf.UIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultToolBarLayout()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JToolBar$DefaultToolBarLayout;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lm", "Ljavax/swing/BoxLayout;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JToolBar;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JToolBar;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeLayoutComponent", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLayoutComponent", "(Ljava/awt/Component;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLayoutComponent", "(Ljava/lang/String;Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutContainer", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidateLayout", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maximumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayoutAlignmentX", "(Ljava/awt/Container;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayoutAlignmentY", "(Ljava/awt/Container;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/BoxLayout;", "")]
		public Dova.JDK.javax.swing.BoxLayout lm_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.BoxLayout>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JToolBar;", "final")]
		public Dova.JDK.javax.swing.JToolBar this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JToolBar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultToolBarLayout(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JToolBar;I)V", "")]
		public DefaultToolBarLayout(Dova.JDK.javax.swing.JToolBar arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JToolBar$DefaultToolBarLayout;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
		public void removeLayoutComponent(Dova.JDK.java.awt.Component arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/lang/Object;)V", "public")]
		public void addLayoutComponent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
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

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
		public void invalidateLayout(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension preferredLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension minimumLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension maximumLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)F", "public")]
		public float getLayoutAlignmentX(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)F", "public")]
		public float getLayoutAlignmentY(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JToolBar$Separator;", "public static")]
	public partial class Separator
		: Dova.JDK.javax.swing.JSeparator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Separator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JToolBar$Separator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "separatorSize", "Ljava/awt/Dimension;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Dimension;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSeparatorSize", "(Ljava/awt/Dimension;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSeparatorSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClassID", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSize", "()Ljava/awt/Dimension;"));
		}

		[JniSignatureAttribute("Ljava/awt/Dimension;", "private")]
		public Dova.JDK.java.awt.Dimension separatorSize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Separator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Separator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
		public Separator(Dova.JDK.java.awt.Dimension arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JToolBar$Separator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
		public void setSeparatorSize(Dova.JDK.java.awt.Dimension arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getSeparatorSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getUIClassID()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getPreferredSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getMinimumSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getMaximumSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JToolBar$AccessibleJToolBar;", "protected")]
	public partial class AccessibleJToolBar
		: Dova.JDK.javax.swing.JComponent.AccessibleJComponent
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJToolBar()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JToolBar$AccessibleJToolBar;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JToolBar;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JToolBar;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
		}

		[JniSignatureAttribute("Ljavax/swing/JToolBar;", "final")]
		public Dova.JDK.javax.swing.JToolBar this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JToolBar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJToolBar(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JToolBar;)V", "protected")]
		public AccessibleJToolBar(Dova.JDK.javax.swing.JToolBar arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JToolBar$AccessibleJToolBar;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
		}
	}
}
