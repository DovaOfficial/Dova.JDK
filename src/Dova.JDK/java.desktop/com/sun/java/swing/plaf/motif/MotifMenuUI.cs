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

[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifMenuUI;", "public")]
public partial class MotifMenuUI
	: Dova.JDK.javax.swing.plaf.basic.BasicMenuUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MotifMenuUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifMenuUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupIsOpen", "(Ljavax/swing/JMenu;[Ljavax/swing/MenuElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMouseInputListener", "(Ljavax/swing/JComponent;)Ljavax/swing/event/MouseInputListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createChangeListener", "(Ljavax/swing/JComponent;)Ljavax/swing/event/ChangeListener;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MotifMenuUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MotifMenuUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifMenuUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/JMenu;[Ljavax/swing/MenuElement;)Z", "private")]
	public bool popupIsOpen(Dova.JDK.javax.swing.JMenu arg0, JavaArray<Dova.JDK.javax.swing.MenuElement> arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/event/MouseInputListener;", "protected")]
	public Dova.JDK.javax.swing.@event.MouseInputListener createMouseInputListener(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.MouseInputListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/event/ChangeListener;", "protected")]
	public Dova.JDK.javax.swing.@event.ChangeListener createChangeListener(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifMenuUI$MotifChangeHandler;", "public")]
	public partial class MotifChangeHandler
		: Dova.JDK.javax.swing.plaf.basic.BasicMenuUI.ChangeHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MotifChangeHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifMenuUI$MotifChangeHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/java/swing/plaf/motif/MotifMenuUI;Ljavax/swing/JMenu;Lcom/sun/java/swing/plaf/motif/MotifMenuUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MotifChangeHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifMenuUI;Ljavax/swing/JMenu;Lcom/sun/java/swing/plaf/motif/MotifMenuUI;)V", "public")]
		public MotifChangeHandler(Dova.JDK.com.sun.java.swing.plaf.motif.MotifMenuUI arg0, Dova.JDK.javax.swing.JMenu arg1, Dova.JDK.com.sun.java.swing.plaf.motif.MotifMenuUI arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifMenuUI$MotifChangeHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifMenuUI$MouseInputHandler;", "protected")]
	public partial class MouseInputHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.@event.MouseInputListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MouseInputHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifMenuUI$MouseInputHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/java/swing/plaf/motif/MotifMenuUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/java/swing/plaf/motif/MotifMenuUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mousePressed", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseReleased", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseClicked", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseExited", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseEntered", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseMoved", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseDragged", "(Ljava/awt/event/MouseEvent;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifMenuUI;", "final")]
		public Dova.JDK.com.sun.java.swing.plaf.motif.MotifMenuUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.motif.MotifMenuUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MouseInputHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/motif/MotifMenuUI;)V", "protected")]
		public MouseInputHandler(Dova.JDK.com.sun.java.swing.plaf.motif.MotifMenuUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifMenuUI$MouseInputHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mousePressed(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseReleased(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseClicked(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseExited(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseEntered(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseMoved(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseDragged(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}
	}
}
