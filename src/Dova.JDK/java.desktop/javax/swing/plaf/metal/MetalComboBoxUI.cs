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

[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalComboBoxUI;", "public")]
public partial class MetalComboBoxUI
	: Dova.JDK.javax.swing.plaf.basic.BasicComboBoxUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MetalComboBoxUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalComboBoxUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configureEditor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JComboBox;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JComboBox;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$500", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$600", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$700", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$800", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateButtonForOcean", "(Ljavax/swing/JButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editablePropertyChanged", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutComboBox", "(Ljava/awt/Container;Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalComboBoxLayoutManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintCurrentValue", "(Ljava/awt/Graphics;Ljava/awt/Rectangle;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPopup", "()Ljavax/swing/plaf/basic/ComboPopup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createArrowButton", "()Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unconfigureEditor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintCurrentValueBackground", "(Ljava/awt/Graphics;Ljava/awt/Rectangle;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPropertyChangeListener", "()Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createEditor", "()Ljavax/swing/ComboBoxEditor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLayoutManager", "()Ljava/awt/LayoutManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseline", "(Ljavax/swing/JComponent;II)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MetalComboBoxUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MetalComboBoxUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalComboBoxUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void configureEditor()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void removeListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;", "static")]
	public static Dova.JDK.javax.swing.JButton access_000(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;", "static")]
	public static Dova.JDK.javax.swing.JButton access_100(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JComboBox;", "static")]
	public static Dova.JDK.javax.swing.JComboBox access_200(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JComboBox;", "static")]
	public static Dova.JDK.javax.swing.JComboBox access_300(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;", "static")]
	public static Dova.JDK.javax.swing.JButton access_400(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;", "static")]
	public static Dova.JDK.javax.swing.JButton access_500(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JList;", "static")]
	public static Dova.JDK.javax.swing.JList access_600(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JList>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JButton;", "static")]
	public static Dova.JDK.javax.swing.JButton access_700(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)Ljavax/swing/JList;", "static")]
	public static Dova.JDK.javax.swing.JList access_800(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JList>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JButton;)V", "private")]
	public void updateButtonForOcean(Dova.JDK.javax.swing.JButton arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "protected")]
	public void editablePropertyChanged(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalComboBoxLayoutManager;)V", "public")]
	public void layoutComboBox(Dova.JDK.java.awt.Container arg0, Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI.MetalComboBoxLayoutManager arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Rectangle;Z)V", "public")]
	public void paintCurrentValue(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Rectangle arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/basic/ComboPopup;", "protected")]
	public Dova.JDK.javax.swing.plaf.basic.ComboPopup createPopup()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.ComboPopup>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JButton;", "protected")]
	public Dova.JDK.javax.swing.JButton createArrowButton()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void unconfigureEditor()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Rectangle;Z)V", "public")]
	public void paintCurrentValueBackground(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Rectangle arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/beans/PropertyChangeListener;", "public")]
	public Dova.JDK.java.beans.PropertyChangeListener createPropertyChangeListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/ComboBoxEditor;", "protected")]
	public Dova.JDK.javax.swing.ComboBoxEditor createEditor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ComboBoxEditor>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/LayoutManager;", "protected")]
	public Dova.JDK.java.awt.LayoutManager createLayoutManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.LayoutManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;II)I", "public")]
	public int getBaseline(Dova.JDK.javax.swing.JComponent arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalPropertyChangeListener;", "public")]
	public partial class MetalPropertyChangeListener
		: Dova.JDK.javax.swing.plaf.basic.BasicComboBoxUI.PropertyChangeHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MetalPropertyChangeListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalPropertyChangeListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalComboBoxUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalComboBoxUI;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MetalPropertyChangeListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)V", "public")]
		public MetalPropertyChangeListener(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalPropertyChangeListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalComboBoxLayoutManager;", "public")]
	public partial class MetalComboBoxLayoutManager
		: Dova.JDK.javax.swing.plaf.basic.BasicComboBoxUI.ComboBoxLayoutManager
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MetalComboBoxLayoutManager()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalComboBoxLayoutManager;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalComboBoxUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "superLayout", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutContainer", "(Ljava/awt/Container;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalComboBoxUI;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MetalComboBoxLayoutManager(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;)V", "public")]
		public MetalComboBoxLayoutManager(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalComboBoxLayoutManager;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
		public void superLayout(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
		public void layoutContainer(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalComboPopup;", "public")]
	public partial class MetalComboPopup
		: Dova.JDK.javax.swing.plaf.basic.BasicComboPopup
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MetalComboPopup()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalComboPopup;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/metal/MetalComboBoxUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/metal/MetalComboBoxUI;Ljavax/swing/JComboBox;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delegateFocus", "(Ljava/awt/event/MouseEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalComboBoxUI;", "final")]
		public Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MetalComboPopup(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/metal/MetalComboBoxUI;Ljavax/swing/JComboBox;)V", "public")]
		public MetalComboPopup(Dova.JDK.javax.swing.plaf.metal.MetalComboBoxUI arg0, Dova.JDK.javax.swing.JComboBox arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalComboBoxUI$MetalComboPopup;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void delegateFocus(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}
