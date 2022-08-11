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

[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "public")]
public partial class BasicSplitPaneUI
	: Dova.JDK.javax.swing.plaf.SplitPaneUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicSplitPaneUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NON_CONTINUOUS_DIVIDER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KEYBOARD_DIVIDER_MOVE_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "splitPane", "Ljavax/swing/JSplitPane;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "layoutManager", "Ljavax/swing/plaf/basic/BasicSplitPaneUI$BasicHorizontalLayoutManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "divider", "Ljavax/swing/plaf/basic/BasicSplitPaneDivider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyChangeListener", "Ljava/beans/PropertyChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focusListener", "Ljava/awt/event/FocusListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Ljavax/swing/plaf/basic/BasicSplitPaneUI$Handler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "managingFocusForwardTraversalKeys", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "managingFocusBackwardTraversalKeys", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dividerSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nonContinuousLayoutDivider", "Ljava/awt/Component;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "draggingHW", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "beginDragDividerLocation", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upKey", "Ljavax/swing/KeyStroke;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "downKey", "Ljavax/swing/KeyStroke;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leftKey", "Ljavax/swing/KeyStroke;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rightKey", "Ljavax/swing/KeyStroke;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "homeKey", "Ljavax/swing/KeyStroke;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endKey", "Ljavax/swing/KeyStroke;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dividerResizeToggleKey", "Ljavax/swing/KeyStroke;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyboardUpLeftListener", "Ljava/awt/event/ActionListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyboardDownRightListener", "Ljava/awt/event/ActionListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyboardHomeListener", "Ljava/awt/event/ActionListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyboardEndListener", "Ljava/awt/event/ActionListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyboardResizeToggleListener", "Ljava/awt/event/ActionListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "orientation", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastDragLocation", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "continuousLayout", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dividerKeyboardResize", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dividerLocationIsSet", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dividerDraggingColor", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rememberPaneSizes", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keepHidden", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "painted", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoreDividerLocationChange", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandler", "()Ljavax/swing/plaf/basic/BasicSplitPaneUI$Handler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOrientation", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrientation", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetLayoutManager", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultNonContinuousLayoutDivider", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNonContinuousLayoutDivider", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNonContinuousLayoutDivider", "(Ljava/awt/Component;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultDivider", "()Ljavax/swing/plaf/basic/BasicSplitPaneDivider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastDragLocation", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLastDragLocation", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setKeepHidden", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHeavyweightDivider", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dragDividerTo", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyboardUpLeftListener", "()Ljava/awt/event/ActionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyboardDownRightListener", "()Ljava/awt/event/ActionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyboardHomeListener", "()Ljava/awt/event/ActionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyboardEndListener", "()Ljava/awt/event/ActionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createKeyboardResizeToggleListener", "()Ljava/awt/event/ActionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyboardMoveIncrement", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDivider", "()Ljavax/swing/plaf/basic/BasicSplitPaneDivider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNonContinuousLayoutDivider", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSplitPane", "()Ljavax/swing/JSplitPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeepHidden", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDragging", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishDraggingTo", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDividerBorderSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputMap", "(I)Ljavax/swing/InputMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFocusListener", "()Ljava/awt/event/FocusListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPropertyChangeListener", "()Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadActionMap", "(Ljavax/swing/plaf/basic/LazyActionMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installKeyboardActions", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallKeyboardActions", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetToPreferredSizes", "(Ljavax/swing/JSplitPane;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDividerLocation", "(Ljavax/swing/JSplitPane;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumDividerLocation", "(Ljavax/swing/JSplitPane;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumDividerLocation", "(Ljavax/swing/JSplitPane;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishedPaintingChildren", "(Ljavax/swing/JSplitPane;Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContinuousLayout", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isContinuousLayout", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDividerLocation", "(Ljavax/swing/JSplitPane;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installUI", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallUI", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInsets", "(Ljavax/swing/JComponent;)Ljava/awt/Insets;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
	public static Dova.JDK.java.lang.String NON_CONTINUOUS_DIVIDER_Property
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

	[JniSignatureAttribute("I", "protected static")]
	public static int KEYBOARD_DIVIDER_MOVE_OFFSET_Property
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

	[JniSignatureAttribute("Ljavax/swing/JSplitPane;", "protected")]
	public Dova.JDK.javax.swing.JSplitPane splitPane_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSplitPane>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$BasicHorizontalLayoutManager;", "protected")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI.BasicHorizontalLayoutManager layoutManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI.BasicHorizontalLayoutManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneDivider;", "protected")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneDivider divider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneDivider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PropertyChangeListener;", "protected")]
	public Dova.JDK.java.beans.PropertyChangeListener propertyChangeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/FocusListener;", "protected")]
	public Dova.JDK.java.awt.@event.FocusListener focusListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$Handler;", "private")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI.Handler handler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set managingFocusForwardTraversalKeys_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set managingFocusBackwardTraversalKeys_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int dividerSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Component;", "protected")]
	public Dova.JDK.java.awt.Component nonContinuousLayoutDivider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool draggingHW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int beginDragDividerLocation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/KeyStroke;", "protected")]
	public Dova.JDK.javax.swing.KeyStroke upKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/KeyStroke;", "protected")]
	public Dova.JDK.javax.swing.KeyStroke downKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/KeyStroke;", "protected")]
	public Dova.JDK.javax.swing.KeyStroke leftKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/KeyStroke;", "protected")]
	public Dova.JDK.javax.swing.KeyStroke rightKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/KeyStroke;", "protected")]
	public Dova.JDK.javax.swing.KeyStroke homeKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/KeyStroke;", "protected")]
	public Dova.JDK.javax.swing.KeyStroke endKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/KeyStroke;", "protected")]
	public Dova.JDK.javax.swing.KeyStroke dividerResizeToggleKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener keyboardUpLeftListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener keyboardDownRightListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener keyboardHomeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener keyboardEndListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener keyboardResizeToggleListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int orientation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int lastDragLocation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool continuousLayout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool dividerKeyboardResize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool dividerLocationIsSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color dividerDraggingColor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool rememberPaneSizes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool keepHidden_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool painted_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool ignoreDividerLocationChange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BasicSplitPaneUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BasicSplitPaneUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/plaf/basic/BasicSplitPaneUI$Handler;", "private")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI.Handler getHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI.Handler>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setOrientation(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getOrientation()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void resetLayoutManager()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "protected")]
	public Dova.JDK.java.awt.Component createDefaultNonContinuousLayoutDivider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "protected")]
	public void setNonContinuousLayoutDivider(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Z)V", "protected")]
	public void setNonContinuousLayoutDivider(Dova.JDK.java.awt.Component arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/basic/BasicSplitPaneDivider;", "public")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneDivider createDefaultDivider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneDivider>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLastDragLocation()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setLastDragLocation(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Z)V", "")]
	public void setKeepHidden(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void addHeavyweightDivider()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void dragDividerTo(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener createKeyboardUpLeftListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener createKeyboardDownRightListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener createKeyboardHomeListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener createKeyboardEndListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/event/ActionListener;", "protected")]
	public Dova.JDK.java.awt.@event.ActionListener createKeyboardResizeToggleListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ActionListener>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int getKeyboardMoveIncrement()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/basic/BasicSplitPaneDivider;", "public")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneDivider getDivider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneDivider>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component getNonContinuousLayoutDivider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JSplitPane;", "public")]
	public Dova.JDK.javax.swing.JSplitPane getSplitPane()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSplitPane>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool getKeepHidden()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void startDragging()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void finishDraggingTo(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getDividerBorderSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljavax/swing/InputMap;", "")]
	public Dova.JDK.javax.swing.InputMap getInputMap(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.InputMap>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/event/FocusListener;", "protected")]
	public Dova.JDK.java.awt.@event.FocusListener createFocusListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusListener>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30]);
	}

	[JniSignatureAttribute("()Ljava/beans/PropertyChangeListener;", "protected")]
	public Dova.JDK.java.beans.PropertyChangeListener createPropertyChangeListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/basic/LazyActionMap;)V", "static")]
	public static void loadActionMap(Dova.JDK.javax.swing.plaf.basic.LazyActionMap arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installKeyboardActions()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallKeyboardActions()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSplitPane;)V", "public")]
	public void resetToPreferredSizes(Dova.JDK.javax.swing.JSplitPane arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSplitPane;I)V", "public")]
	public void setDividerLocation(Dova.JDK.javax.swing.JSplitPane arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSplitPane;)I", "public")]
	public int getMinimumDividerLocation(Dova.JDK.javax.swing.JSplitPane arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JSplitPane;)I", "public")]
	public int getMaximumDividerLocation(Dova.JDK.javax.swing.JSplitPane arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JSplitPane;Ljava/awt/Graphics;)V", "public")]
	public void finishedPaintingChildren(Dova.JDK.javax.swing.JSplitPane arg0, Dova.JDK.java.awt.Graphics arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setContinuousLayout(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isContinuousLayout()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JSplitPane;)I", "public")]
	public int getDividerLocation(Dova.JDK.javax.swing.JSplitPane arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45]);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void installUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void uninstallUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMaximumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Insets;", "public")]
	public Dova.JDK.java.awt.Insets getInsets(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$Actions;", "private static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$Actions;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEGATIVE_INCREMENT", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POSITIVE_INCREMENT", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SELECT_MIN", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SELECT_MAX", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "START_RESIZE", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOGGLE_FOCUS", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOCUS_OUT_FORWARD", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOCUS_OUT_BACKWARD", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveFocus", "(Ljavax/swing/JSplitPane;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextSide", "(Ljavax/swing/JSplitPane;Ljava/awt/Component;)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstAvailableComponent", "(Ljava/awt/Component;)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toggleFocus", "(Ljavax/swing/JSplitPane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String NEGATIVE_INCREMENT_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String POSITIVE_INCREMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String SELECT_MIN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String SELECT_MAX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String START_RESIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String TOGGLE_FOCUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String FOCUS_OUT_FORWARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String FOCUS_OUT_BACKWARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
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

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$Actions;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JSplitPane;I)V", "private")]
		public void moveFocus(Dova.JDK.javax.swing.JSplitPane arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/JSplitPane;Ljava/awt/Component;)Ljava/awt/Component;", "private")]
		public Dova.JDK.java.awt.Component getNextSide(Dova.JDK.javax.swing.JSplitPane arg0, Dova.JDK.java.awt.Component arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Component;", "private")]
		public Dova.JDK.java.awt.Component getFirstAvailableComponent(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/JSplitPane;)V", "private")]
		public void toggleFocus(Dova.JDK.javax.swing.JSplitPane arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$BasicHorizontalLayoutManager;", "public")]
	public partial class BasicHorizontalLayoutManager
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.LayoutManager2
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicHorizontalLayoutManager()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$BasicHorizontalLayoutManager;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sizes", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "components", "[Ljava/awt/Component;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastSplitPaneSize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doReset", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "axis", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSplitPaneUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateComponents", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAvailableSize", "(Ljava/awt/Dimension;Ljava/awt/Insets;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSizeForPrimaryAxis", "(Ljava/awt/Dimension;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSizeForPrimaryAxis", "(Ljava/awt/Insets;Z)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "distributeSpace", "(IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitialLocation", "(Ljava/awt/Insets;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setComponentToSize", "(Ljava/awt/Component;IILjava/awt/Insets;Ljava/awt/Dimension;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSizeForSecondaryAxis", "(Ljava/awt/Insets;Z)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSizeForSecondaryAxis", "(Ljava/awt/Dimension;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSizeOfComponent", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSizeOfComponent", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSizes", "()[I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSizes", "()[I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetSizeAt", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSizeOfComponent", "(Ljava/awt/Component;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetToPreferredSizes", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetToPreferredSizes", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDividerLocation", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSizes", "([I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSizes", "()[I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeLayoutComponent", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLayoutComponent", "(Ljava/lang/String;Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLayoutComponent", "(Ljava/awt/Component;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutContainer", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidateLayout", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maximumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayoutAlignmentX", "(Ljava/awt/Container;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayoutAlignmentY", "(Ljava/awt/Container;)F"));
		}

		[JniSignatureAttribute("[I", "protected")]
		public JavaArray<int> sizes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/awt/Component;", "protected")]
		public JavaArray<Dova.JDK.java.awt.Component> components_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Component>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int lastSplitPaneSize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool doReset_Property
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
		public int axis_Property
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

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicHorizontalLayoutManager(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "")]
		public BasicHorizontalLayoutManager(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;I)V", "")]
		public BasicHorizontalLayoutManager(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$BasicHorizontalLayoutManager;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void updateComponents()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/awt/Dimension;Ljava/awt/Insets;)I", "protected")]
		public int getAvailableSize(Dova.JDK.java.awt.Dimension arg0, Dova.JDK.java.awt.Insets arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Dimension;)I", "")]
		public int getSizeForPrimaryAxis(Dova.JDK.java.awt.Dimension arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Insets;Z)I", "")]
		public int getSizeForPrimaryAxis(Dova.JDK.java.awt.Insets arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(IZ)V", "")]
		public void distributeSpace(int arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Insets;)I", "protected")]
		public int getInitialLocation(Dova.JDK.java.awt.Insets arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;IILjava/awt/Insets;Ljava/awt/Dimension;)V", "protected")]
		public void setComponentToSize(Dova.JDK.java.awt.Component arg0, int arg1, int arg2, Dova.JDK.java.awt.Insets arg3, Dova.JDK.java.awt.Dimension arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Ljava/awt/Insets;Z)I", "")]
		public int getSizeForSecondaryAxis(Dova.JDK.java.awt.Insets arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Dimension;)I", "")]
		public int getSizeForSecondaryAxis(Dova.JDK.java.awt.Dimension arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "protected")]
		public int getPreferredSizeOfComponent(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "")]
		public int getMinimumSizeOfComponent(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[I", "")]
		public JavaArray<int> getPreferredSizes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}

		[JniSignatureAttribute("()[I", "")]
		public JavaArray<int> getMinimumSizes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}

		[JniSignatureAttribute("(I)V", "protected")]
		public void resetSizeAt(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)I", "protected")]
		public int getSizeOfComponent(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "")]
		public void resetToPreferredSizes(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void resetToPreferredSizes()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
		}

		[JniSignatureAttribute("(II)V", "")]
		public void setDividerLocation(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		}

		[JniSignatureAttribute("([I)V", "protected")]
		public void setSizes(JavaArray<int> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("()[I", "protected")]
		public JavaArray<int> getSizes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
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

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/lang/Object;)V", "public")]
		public void addLayoutComponent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
		public void layoutContainer(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
		public void invalidateLayout(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension preferredLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension minimumLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension maximumLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)F", "public")]
		public float getLayoutAlignmentX(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)F", "public")]
		public float getLayoutAlignmentY(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$Handler;", "private")]
	public partial class Handler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.FocusListener
		, Dova.JDK.java.beans.PropertyChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Handler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$Handler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSplitPaneUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI>(ret);
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

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "private")]
		public Handler(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$Handler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardUpLeftHandler;", "public")]
	public partial class KeyboardUpLeftHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyboardUpLeftHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardUpLeftHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSplitPaneUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyboardUpLeftHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "public")]
		public KeyboardUpLeftHandler(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardUpLeftHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardDownRightHandler;", "public")]
	public partial class KeyboardDownRightHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyboardDownRightHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardDownRightHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSplitPaneUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyboardDownRightHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "public")]
		public KeyboardDownRightHandler(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardDownRightHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardHomeHandler;", "public")]
	public partial class KeyboardHomeHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyboardHomeHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardHomeHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSplitPaneUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyboardHomeHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "public")]
		public KeyboardHomeHandler(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardHomeHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardEndHandler;", "public")]
	public partial class KeyboardEndHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyboardEndHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardEndHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSplitPaneUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyboardEndHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "public")]
		public KeyboardEndHandler(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardEndHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardResizeToggleHandler;", "public")]
	public partial class KeyboardResizeToggleHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyboardResizeToggleHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardResizeToggleHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSplitPaneUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyboardResizeToggleHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "public")]
		public KeyboardResizeToggleHandler(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$KeyboardResizeToggleHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$BasicVerticalLayoutManager;", "public")]
	public partial class BasicVerticalLayoutManager
		: Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI.BasicHorizontalLayoutManager
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicVerticalLayoutManager()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$BasicVerticalLayoutManager;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicVerticalLayoutManager(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "public")]
		public BasicVerticalLayoutManager(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$BasicVerticalLayoutManager;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$FocusHandler;", "public")]
	public partial class FocusHandler
		: Dova.JDK.java.awt.@event.FocusAdapter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FocusHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$FocusHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSplitPaneUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FocusHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "public")]
		public FocusHandler(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$FocusHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI$PropertyHandler;", "public")]
	public partial class PropertyHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.beans.PropertyChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PropertyHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSplitPaneUI$PropertyHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSplitPaneUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSplitPaneUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PropertyHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", "public")]
		public PropertyHandler(Dova.JDK.javax.swing.plaf.basic.BasicSplitPaneUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSplitPaneUI$PropertyHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}
