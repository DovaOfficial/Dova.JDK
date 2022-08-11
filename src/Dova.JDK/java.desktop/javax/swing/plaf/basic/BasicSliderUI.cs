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

[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI;", "public")]
public partial class BasicSliderUI
	: Dova.JDK.javax.swing.plaf.SliderUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicSliderUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHARED_ACTION", "Ljavax/swing/plaf/basic/BasicSliderUI$Actions;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POSITIVE_SCROLL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEGATIVE_SCROLL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIN_SCROLL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_SCROLL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scrollTimer", "Ljavax/swing/Timer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slider", "Ljavax/swing/JSlider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focusInsets", "Ljava/awt/Insets;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "insetCache", "Ljava/awt/Insets;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leftToRightCache", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focusRect", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentRect", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "labelRect", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tickRect", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trackRect", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thumbRect", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trackBuffer", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isDragging", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trackListener", "Ljavax/swing/plaf/basic/BasicSliderUI$TrackListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changeListener", "Ljavax/swing/event/ChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentListener", "Ljava/awt/event/ComponentListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focusListener", "Ljava/awt/event/FocusListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scrollListener", "Ljavax/swing/plaf/basic/BasicSliderUI$ScrollListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyChangeListener", "Ljava/beans/PropertyChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Ljavax/swing/plaf/basic/BasicSliderUI$Handler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastValue", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shadowColor", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "highlightColor", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focusColor", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "checkedLabelBaselines", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sameLabelBaselines", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "unionRect", "Ljava/awt/Rectangle;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JSlider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandler", "()Ljavax/swing/plaf/basic/BasicSliderUI$Handler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredVerticalSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredHorizontalSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumVerticalSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumHorizontalSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateFocusRect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateContentRect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateTrackBuffer", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateTrackRect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateTickRect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateLabelRect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTickSpacing", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHighestValueLabel", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowestValueLabel", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintMinorTickForHorizSlider", "(Ljava/awt/Graphics;Ljava/awt/Rectangle;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintMajorTickForHorizSlider", "(Ljava/awt/Graphics;Ljava/awt/Rectangle;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintMinorTickForVertSlider", "(Ljava/awt/Graphics;Ljava/awt/Rectangle;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintMajorTickForVertSlider", "(Ljava/awt/Graphics;Ljava/awt/Rectangle;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintHorizontalLabel", "(Ljava/awt/Graphics;ILjava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintVerticalLabel", "(Ljava/awt/Graphics;ILjava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidthOfHighValueLabel", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidthOfLowValueLabel", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeightOfHighValueLabel", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeightOfLowValueLabel", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scrollDueToClickInTrack", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHighlightColor", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createComponentListener", "(Ljavax/swing/JSlider;)Ljava/awt/event/ComponentListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawInverted", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "yPositionForValue", "(III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "yPositionForValue", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "labelsHaveSameBaselines", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTickLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeightOfTallestLabel", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowestValue", "()Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHighestValue", "()Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recalculateIfInsetsChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateThumbSize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateThumbLocation", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidthOfWidestLabel", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "xPositionForValue", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setThumbLocation", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateGeometry", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recalculateIfOrientationChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueForYPosition", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueForXPosition", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThumbSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputMap", "(ILjavax/swing/JSlider;)Ljavax/swing/InputMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFocusListener", "(Ljavax/swing/JSlider;)Ljava/awt/event/FocusListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallDefaults", "(Ljavax/swing/JSlider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPropertyChangeListener", "(Ljavax/swing/JSlider;)Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadActionMap", "(Ljavax/swing/plaf/basic/LazyActionMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShadowColor", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installKeyboardActions", "(Ljavax/swing/JSlider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallKeyboardActions", "(Ljavax/swing/JSlider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFocusColor", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintTicks", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintLabels", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintTrack", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintThumb", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTrackListener", "(Ljavax/swing/JSlider;)Ljavax/swing/plaf/basic/BasicSliderUI$TrackListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createScrollListener", "(Ljavax/swing/JSlider;)Ljavax/swing/plaf/basic/BasicSliderUI$ScrollListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scrollByBlock", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scrollByUnit", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintFocus", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createChangeListener", "(Ljavax/swing/JSlider;)Ljavax/swing/event/ChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "(Ljavax/swing/JSlider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "(Ljavax/swing/JSlider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallListeners", "(Ljavax/swing/JSlider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDragging", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installUI", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallUI", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseline", "(Ljavax/swing/JComponent;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaselineResizeBehavior", "(Ljavax/swing/JComponent;)Ljava/awt/Component$BaselineResizeBehavior;"));
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$Actions;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.Actions SHARED_ACTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.Actions>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int POSITIVE_SCROLL_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int NEGATIVE_SCROLL_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int MIN_SCROLL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_SCROLL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Timer;", "protected")]
	public Dova.JDK.javax.swing.Timer scrollTimer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Timer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JSlider;", "protected")]
	public Dova.JDK.javax.swing.JSlider slider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSlider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "protected")]
	public Dova.JDK.java.awt.Insets focusInsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "protected")]
	public Dova.JDK.java.awt.Insets insetCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool leftToRightCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "protected")]
	public Dova.JDK.java.awt.Rectangle focusRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "protected")]
	public Dova.JDK.java.awt.Rectangle contentRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "protected")]
	public Dova.JDK.java.awt.Rectangle labelRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "protected")]
	public Dova.JDK.java.awt.Rectangle tickRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "protected")]
	public Dova.JDK.java.awt.Rectangle trackRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "protected")]
	public Dova.JDK.java.awt.Rectangle thumbRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int trackBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool isDragging_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$TrackListener;", "protected")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.TrackListener trackListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.TrackListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/ChangeListener;", "protected")]
	public Dova.JDK.javax.swing.@event.ChangeListener changeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/ComponentListener;", "protected")]
	public Dova.JDK.java.awt.@event.ComponentListener componentListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ComponentListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/FocusListener;", "protected")]
	public Dova.JDK.java.awt.@event.FocusListener focusListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$ScrollListener;", "protected")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.ScrollListener scrollListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.ScrollListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PropertyChangeListener;", "protected")]
	public Dova.JDK.java.beans.PropertyChangeListener propertyChangeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$Handler;", "private")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.Handler handler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int lastValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color shadowColor_Property
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
	public Dova.JDK.java.awt.Color highlightColor_Property
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
	public Dova.JDK.java.awt.Color focusColor_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool checkedLabelBaselines_Property
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
	public bool sameLabelBaselines_Property
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

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private static")]
	public static Dova.JDK.java.awt.Rectangle unionRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BasicSliderUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BasicSliderUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)V", "public")]
	public BasicSliderUI(Dova.JDK.javax.swing.JSlider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/plaf/basic/BasicSliderUI$Handler;", "private")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.Handler getHandler()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.Handler>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredVerticalSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredHorizontalSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumVerticalSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumHorizontalSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calculateFocusRect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calculateContentRect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calculateTrackBuffer()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calculateTrackRect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calculateTickRect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calculateLabelRect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()I", "private")]
	public int getTickSpacing()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "protected")]
	public Dova.JDK.java.awt.Component getHighestValueLabel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "protected")]
	public Dova.JDK.java.awt.Component getLowestValueLabel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Rectangle;I)V", "protected")]
	public void paintMinorTickForHorizSlider(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Rectangle arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Rectangle;I)V", "protected")]
	public void paintMajorTickForHorizSlider(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Rectangle arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Rectangle;I)V", "protected")]
	public void paintMinorTickForVertSlider(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Rectangle arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Rectangle;I)V", "protected")]
	public void paintMajorTickForVertSlider(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Rectangle arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;ILjava/awt/Component;)V", "protected")]
	public void paintHorizontalLabel(Dova.JDK.java.awt.Graphics arg0, int arg1, Dova.JDK.java.awt.Component arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;ILjava/awt/Component;)V", "protected")]
	public void paintVerticalLabel(Dova.JDK.java.awt.Graphics arg0, int arg1, Dova.JDK.java.awt.Component arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getWidthOfHighValueLabel()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getWidthOfLowValueLabel()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getHeightOfHighValueLabel()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getHeightOfLowValueLabel()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void scrollDueToClickInTrack(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "protected")]
	public Dova.JDK.java.awt.Color getHighlightColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)Ljava/awt/event/ComponentListener;", "protected")]
	public Dova.JDK.java.awt.@event.ComponentListener createComponentListener(Dova.JDK.javax.swing.JSlider arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.ComponentListener>(ret);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool drawInverted()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("(III)I", "protected")]
	public int yPositionForValue(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int yPositionForValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool labelsHaveSameBaselines()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getTickLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getHeightOfTallestLabel()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Integer;", "protected")]
	public Dova.JDK.java.lang.Integer getLowestValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Integer;", "protected")]
	public Dova.JDK.java.lang.Integer getHighestValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void recalculateIfInsetsChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calculateThumbSize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calculateThumbLocation()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37]);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getWidthOfWidestLabel()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[38]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int xPositionForValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setThumbLocation(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calculateGeometry()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void recalculateIfOrientationChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int valueForYPosition(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int valueForXPosition(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "protected")]
	public Dova.JDK.java.awt.Dimension getThumbSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(ILjavax/swing/JSlider;)Ljavax/swing/InputMap;", "")]
	public Dova.JDK.javax.swing.InputMap getInputMap(int arg0, Dova.JDK.javax.swing.JSlider arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.InputMap>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)Ljava/awt/event/FocusListener;", "protected")]
	public Dova.JDK.java.awt.@event.FocusListener createFocusListener(Dova.JDK.javax.swing.JSlider arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.FocusListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)V", "protected")]
	public void uninstallDefaults(Dova.JDK.javax.swing.JSlider arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)Ljava/beans/PropertyChangeListener;", "protected")]
	public Dova.JDK.java.beans.PropertyChangeListener createPropertyChangeListener(Dova.JDK.javax.swing.JSlider arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/basic/LazyActionMap;)V", "static")]
	public static void loadActionMap(Dova.JDK.javax.swing.plaf.basic.LazyActionMap arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "protected")]
	public Dova.JDK.java.awt.Color getShadowColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)V", "protected")]
	public void installKeyboardActions(Dova.JDK.javax.swing.JSlider arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)V", "protected")]
	public void uninstallKeyboardActions(Dova.JDK.javax.swing.JSlider arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "protected")]
	public Dova.JDK.java.awt.Color getFocusColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void paintTicks(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void paintLabels(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void paintTrack(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void paintThumb(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)Ljavax/swing/plaf/basic/BasicSliderUI$TrackListener;", "protected")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.TrackListener createTrackListener(Dova.JDK.javax.swing.JSlider arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.TrackListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)Ljavax/swing/plaf/basic/BasicSliderUI$ScrollListener;", "protected")]
	public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.ScrollListener createScrollListener(Dova.JDK.javax.swing.JSlider arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI.ScrollListener>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void scrollByBlock(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void scrollByUnit(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
	public void paintFocus(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)Ljavax/swing/event/ChangeListener;", "protected")]
	public Dova.JDK.javax.swing.@event.ChangeListener createChangeListener(Dova.JDK.javax.swing.JSlider arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)V", "protected")]
	public void installDefaults(Dova.JDK.javax.swing.JSlider arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)V", "protected")]
	public void installListeners(Dova.JDK.javax.swing.JSlider arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JSlider;)V", "protected")]
	public void uninstallListeners(Dova.JDK.javax.swing.JSlider arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool isDragging()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[70]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void installUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void uninstallUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMaximumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;II)I", "public")]
	public int getBaseline(Dova.JDK.javax.swing.JComponent arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Component$BaselineResizeBehavior;", "public")]
	public Dova.JDK.java.awt.Component.BaselineResizeBehavior getBaselineResizeBehavior(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component.BaselineResizeBehavior>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$TrackListener;", "public")]
	public partial class TrackListener
		: Dova.JDK.javax.swing.@event.MouseInputAdapter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TrackListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$TrackListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentMouseX", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentMouseY", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSliderUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSliderUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldScroll", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mousePressed", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseReleased", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseMoved", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mouseDragged", "(Ljava/awt/event/MouseEvent;)V"));
		}

		[JniSignatureAttribute("I", "protected transient")]
		public int offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "protected transient")]
		public int currentMouseX_Property
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

		[JniSignatureAttribute("I", "protected transient")]
		public int currentMouseY_Property
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

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TrackListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSliderUI;)V", "public")]
		public TrackListener(Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$TrackListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Z", "public")]
		public bool shouldScroll(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mousePressed(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseReleased(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseMoved(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseDragged(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$ScrollListener;", "public")]
	public partial class ScrollListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ScrollListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$ScrollListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "direction", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "useBlockIncrement", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSliderUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSliderUI;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSliderUI;IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDirection", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setScrollByBlock", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int direction_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool useBlockIncrement_Property
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

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ScrollListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSliderUI;)V", "public")]
		public ScrollListener(Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSliderUI;IZ)V", "public")]
		public ScrollListener(Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$ScrollListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)V", "public")]
		public void setDirection(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setScrollByBlock(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$Handler;", "private")]
	public partial class Handler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.@event.ChangeListener
		, Dova.JDK.java.awt.@event.ComponentListener
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$Handler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSliderUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSliderUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentResized", "(Ljava/awt/event/ComponentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentMoved", "(Ljava/awt/event/ComponentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentShown", "(Ljava/awt/event/ComponentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentHidden", "(Ljava/awt/event/ComponentEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI>(ret);
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

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSliderUI;)V", "private")]
		public Handler(Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$Handler;";
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

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentResized(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentMoved(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentShown(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentHidden(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$Actions;", "private static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$Actions;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POSITIVE_UNIT_INCREMENT", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POSITIVE_BLOCK_INCREMENT", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEGATIVE_UNIT_INCREMENT", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEGATIVE_BLOCK_INCREMENT", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIN_SCROLL_INCREMENT", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_SCROLL_INCREMENT", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scroll", "(Ljavax/swing/JSlider;Ljavax/swing/plaf/basic/BasicSliderUI;IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String POSITIVE_UNIT_INCREMENT_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String POSITIVE_BLOCK_INCREMENT_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String NEGATIVE_UNIT_INCREMENT_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String NEGATIVE_BLOCK_INCREMENT_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String MIN_SCROLL_INCREMENT_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String MAX_SCROLL_INCREMENT_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Actions(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Actions() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public Actions(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$Actions;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JSlider;Ljavax/swing/plaf/basic/BasicSliderUI;IZ)V", "private")]
		public void scroll(Dova.JDK.javax.swing.JSlider arg0, Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg1, int arg2, bool arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$SharedActionScroller;", "static")]
	public partial class SharedActionScroller
		: Dova.JDK.javax.swing.AbstractAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SharedActionScroller()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$SharedActionScroller;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dir", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "block", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int dir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool block_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SharedActionScroller(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IZ)V", "public")]
		public SharedActionScroller(int arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$SharedActionScroller;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$ActionScroller;", "public")]
	public partial class ActionScroller
		: Dova.JDK.javax.swing.AbstractAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ActionScroller()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$ActionScroller;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dir", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "block", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slider", "Ljavax/swing/JSlider;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSliderUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSliderUI;Ljavax/swing/JSlider;IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int dir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool block_Property
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

		[JniSignatureAttribute("Ljavax/swing/JSlider;", "")]
		public Dova.JDK.javax.swing.JSlider slider_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSlider>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ActionScroller(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSliderUI;Ljavax/swing/JSlider;IZ)V", "public")]
		public ActionScroller(Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg0, Dova.JDK.javax.swing.JSlider arg1, int arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$ActionScroller;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$FocusHandler;", "public")]
	public partial class FocusHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.FocusListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FocusHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$FocusHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSliderUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSliderUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI>(ret);
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

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSliderUI;)V", "public")]
		public FocusHandler(Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$FocusHandler;";
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

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$ComponentHandler;", "public")]
	public partial class ComponentHandler
		: Dova.JDK.java.awt.@event.ComponentAdapter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ComponentHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$ComponentHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSliderUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSliderUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentResized", "(Ljava/awt/event/ComponentEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ComponentHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSliderUI;)V", "public")]
		public ComponentHandler(Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$ComponentHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
		public void componentResized(Dova.JDK.java.awt.@event.ComponentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$ChangeHandler;", "public")]
	public partial class ChangeHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.@event.ChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChangeHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$ChangeHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSliderUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSliderUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChangeHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSliderUI;)V", "public")]
		public ChangeHandler(Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$ChangeHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI$PropertyChangeHandler;", "public")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicSliderUI$PropertyChangeHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/basic/BasicSliderUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/basic/BasicSliderUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicSliderUI;", "final")]
		public Dova.JDK.javax.swing.plaf.basic.BasicSliderUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicSliderUI>(ret);
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

		[JniSignatureAttribute("(Ljavax/swing/plaf/basic/BasicSliderUI;)V", "public")]
		public PropertyChangeHandler(Dova.JDK.javax.swing.plaf.basic.BasicSliderUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicSliderUI$PropertyChangeHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}
