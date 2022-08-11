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

namespace Dova.JDK.javax.swing.plaf.basic;

[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicMenuBarUI;", "public")]
public partial class BasicMenuBarUI
	: Dova.JDK.javax.swing.plaf.MenuBarUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicMenuBarUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicMenuBarUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "menuBar", "Ljavax/swing/JMenuBar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "containerListener", "Ljava/awt/event/ContainerListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changeListener", "Ljavax/swing/event/ChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Ljavax/swing/plaf/basic/BasicMenuBarUI$Handler;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandler", "()Ljavax/swing/plaf/basic/BasicMenuBarUI$Handler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallKeyboardActions", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installKeyboardActions", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadActionMap", "(Ljavax/swing/plaf/basic/LazyActionMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installUI", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallUI", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputMap", "(I)Ljavax/swing/InputMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createContainerListener", "()Ljava/awt/event/ContainerListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createChangeListener", "()Ljavax/swing/event/ChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuBar;", "protected")]
	public Dova.JDK.javax.swing.JMenuBar menuBar_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuBar>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ContainerListener;", "protected")]
	public Dova.JDK.java.awt.@event.ContainerListener containerListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ContainerListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/ChangeListener;", "protected")]
	public Dova.JDK.javax.swing.@event.ChangeListener changeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicMenuBarUI$Handler;", "private")]
	public Dova.JDK.javax.swing.plaf.basic.BasicMenuBarUI.Handler handler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicMenuBarUI.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BasicMenuBarUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BasicMenuBarUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicMenuBarUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/plaf/basic/BasicMenuBarUI$Handler;", "private")]
	public Dova.JDK.javax.swing.plaf.basic.BasicMenuBarUI.Handler getHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicMenuBarUI.Handler>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallKeyboardActions()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installKeyboardActions()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/basic/LazyActionMap;)V", "static")]
	public static void loadActionMap(Dova.JDK.javax.swing.plaf.basic.LazyActionMap arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void installUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void uninstallUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/InputMap;", "")]
	public Dova.JDK.javax.swing.InputMap getInputMap(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.InputMap>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/event/ContainerListener;", "protected")]
	public Dova.JDK.java.awt.@event.ContainerListener createContainerListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ContainerListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/event/ChangeListener;", "protected")]
	public Dova.JDK.javax.swing.@event.ChangeListener createChangeListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMaximumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicMenuBarUI$Actions;", "private static")]
	public partial class Actions
		: Dova.JDK.sun.swing.UIAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Actions()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicMenuBarUI$Actions;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TAKE_FOCUS", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String TAKE_FOCUS_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Actions(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public Actions(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicMenuBarUI$Actions;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicMenuBarUI$Handler;", "private")]
	public partial class Handler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.@event.ChangeListener
		, Dova.JDK.java.awt.@event.ContainerListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Handler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicMenuBarUI$Handler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicMenuBarUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicMenuBarUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentAdded", "(Ljava/awt/event/ContainerEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentRemoved", "(Ljava/awt/event/ContainerEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicMenuBarUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicMenuBarUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicMenuBarUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Handler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicMenuBarUI;)V", "private")]
		public Handler(Dova.JDK.javax.swing.plaf.basic.BasicMenuBarUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicMenuBarUI$Handler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ContainerEvent;)V", "public")]
		public void componentAdded(Dova.JDK.java.awt.@event.ContainerEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ContainerEvent;)V", "public")]
		public void componentRemoved(Dova.JDK.java.awt.@event.ContainerEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}
}
