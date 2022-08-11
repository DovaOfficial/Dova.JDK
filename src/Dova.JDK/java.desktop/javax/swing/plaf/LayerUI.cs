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

namespace Dova.JDK.javax.swing.plaf;

[JniSignatureAttribute("Ljavax/swing/plaf/LayerUI;", "public")]
public partial class LayerUI
	: Dova.JDK.javax.swing.plaf.ComponentUI
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LayerUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/LayerUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyChangeSupport", "Ljava/beans/PropertyChangeSupport;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyPropertyChange", "(Ljava/beans/PropertyChangeEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installUI", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallUI", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintImmediately", "(IIIILjavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "(Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLayout", "(Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processKeyEvent", "(Ljava/awt/event/KeyEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processFocusEvent", "(Ljava/awt/event/FocusEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processMouseEvent", "(Ljava/awt/event/MouseEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processMouseMotionEvent", "(Ljava/awt/event/MouseEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processMouseWheelEvent", "(Ljava/awt/event/MouseWheelEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processComponentEvent", "(Ljava/awt/event/ComponentEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processInputMethodEvent", "(Ljava/awt/event/InputMethodEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processHierarchyEvent", "(Ljava/awt/event/HierarchyEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processHierarchyBoundsEvent", "(Ljava/awt/event/HierarchyEvent;Ljavax/swing/JLayer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseline", "(Ljavax/swing/JComponent;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaselineResizeBehavior", "(Ljavax/swing/JComponent;)Ljava/awt/Component$BaselineResizeBehavior;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "imageUpdate", "(Ljava/awt/Image;IIIIILjavax/swing/JLayer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eventDispatched", "(Ljava/awt/AWTEvent;Ljavax/swing/JLayer;)V"));
	}

	[JniSignatureAttribute("Ljava/beans/PropertyChangeSupport;", "private final")]
	public Dova.JDK.java.beans.PropertyChangeSupport propertyChangeSupport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeSupport>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LayerUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public LayerUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/LayerUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;Ljavax/swing/JLayer;)V", "public")]
	public void applyPropertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void installUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void uninstallUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(IIIILjavax/swing/JLayer;)V", "public")]
	public void paintImmediately(int arg0, int arg1, int arg2, int arg3, Dova.JDK.javax.swing.JLayer arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/swing/JLayer;)V", "public")]
	public void updateUI(Dova.JDK.javax.swing.JLayer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JLayer;)V", "public")]
	public void doLayout(Dova.JDK.javax.swing.JLayer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "protected")]
	public void firePropertyChange(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;Ljavax/swing/JLayer;)V", "protected")]
	public void processKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;", "public")]
	public JavaArray<Dova.JDK.java.beans.PropertyChangeListener> getPropertyChangeListeners(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.PropertyChangeListener>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/beans/PropertyChangeListener;", "public")]
	public JavaArray<Dova.JDK.java.beans.PropertyChangeListener> getPropertyChangeListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.PropertyChangeListener>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;Ljavax/swing/JLayer;)V", "protected")]
	public void processFocusEvent(Dova.JDK.java.awt.@event.FocusEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;Ljavax/swing/JLayer;)V", "protected")]
	public void processMouseEvent(Dova.JDK.java.awt.@event.MouseEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;Ljavax/swing/JLayer;)V", "protected")]
	public void processMouseMotionEvent(Dova.JDK.java.awt.@event.MouseEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseWheelEvent;Ljavax/swing/JLayer;)V", "protected")]
	public void processMouseWheelEvent(Dova.JDK.java.awt.@event.MouseWheelEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;Ljavax/swing/JLayer;)V", "protected")]
	public void processComponentEvent(Dova.JDK.java.awt.@event.ComponentEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/InputMethodEvent;Ljavax/swing/JLayer;)V", "protected")]
	public void processInputMethodEvent(Dova.JDK.java.awt.@event.InputMethodEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyEvent;Ljavax/swing/JLayer;)V", "protected")]
	public void processHierarchyEvent(Dova.JDK.java.awt.@event.HierarchyEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/HierarchyEvent;Ljavax/swing/JLayer;)V", "protected")]
	public void processHierarchyBoundsEvent(Dova.JDK.java.awt.@event.HierarchyEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
	public void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void addPropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
	public void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void removePropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMaximumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;II)I", "public")]
	public int getBaseline(Dova.JDK.javax.swing.JComponent arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Component$BaselineResizeBehavior;", "public")]
	public Dova.JDK.java.awt.Component.BaselineResizeBehavior getBaselineResizeBehavior(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component.BaselineResizeBehavior>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIIILjavax/swing/JLayer;)Z", "public")]
	public bool imageUpdate(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.javax.swing.JLayer arg6)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;Ljavax/swing/JLayer;)V", "public")]
	public void eventDispatched(Dova.JDK.java.awt.AWTEvent arg0, Dova.JDK.javax.swing.JLayer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}
}
