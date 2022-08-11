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

namespace Dova.JDK.javax.swing.plaf.synth;

[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthTabbedPaneUI;", "public")]
public partial class SynthTabbedPaneUI
	: Dova.JDK.javax.swing.plaf.basic.BasicTabbedPaneUI
	, Dova.JDK.java.beans.PropertyChangeListener
	, Dova.JDK.javax.swing.plaf.synth.SynthUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SynthTabbedPaneUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/synth/SynthTabbedPaneUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabOverlap", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extendTabsToBase", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabAreaContext", "Ljavax/swing/plaf/synth/SynthContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabContext", "Ljavax/swing/plaf/synth/SynthContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabContentContext", "Ljavax/swing/plaf/synth/SynthContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "style", "Ljavax/swing/plaf/synth/SynthStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabStyle", "Ljavax/swing/plaf/synth/SynthStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabAreaStyle", "Ljavax/swing/plaf/synth/SynthStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabContentStyle", "Ljavax/swing/plaf/synth/SynthStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textRect", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iconRect", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabAreaBounds", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabAreaStatesMatchSelectedTab", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nudgeSelectedLabel", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectedTabIsPressed", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "(Ljavax/swing/JComponent;I)Ljavax/swing/plaf/synth/SynthContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/synth/SynthContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/synth/Region;I)Ljavax/swing/plaf/synth/SynthContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintText", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;ILjava/awt/Font;Ljava/awt/FontMetrics;ILjava/lang/String;Ljava/awt/Rectangle;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLayoutManager", "()Ljava/awt/LayoutManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createScrollButton", "(I)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTabLabelShiftX", "(IIZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTabLabelShiftY", "(IIZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureCurrentLayout", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scrollableTabLayoutEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintTabArea", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IILjava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintTabArea", "(Ljava/awt/Graphics;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintContentBorder", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTabContext", "(IZZZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintTab", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;I[Ljava/awt/Rectangle;ILjava/awt/Rectangle;Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRolloverTab", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutLabel", "(Ljavax/swing/plaf/synth/SynthContext;ILjava/awt/FontMetrics;ILjava/lang/String;Ljavax/swing/Icon;Ljava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTabInsets", "(II)Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateTabWidth", "(IILjava/awt/FontMetrics;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMaxTabHeight", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMaxTabWidth", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$500", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$600", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$700", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$800", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$900", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1000", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1100", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1200", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1300", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1400", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1500", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1600", "(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateStyle", "(Ljavax/swing/JTabbedPane;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallListeners", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMouseListener", "()Ljava/awt/event/MouseListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBorder", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "()Ljava/awt/FontMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseline", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
	}

	[JniSignatureAttribute("I", "private")]
	public int tabOverlap_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool extendTabsToBase_Property
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

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthContext;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext tabAreaContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthContext;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext tabContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthContext;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext tabContentContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthStyle;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle style_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthStyle;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle tabStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthStyle;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle tabAreaStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthStyle;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle tabContentStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle textRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle iconRect_Property
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

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle tabAreaBounds_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool tabAreaStatesMatchSelectedTab_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool nudgeSelectedLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool selectedTabIsPressed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SynthTabbedPaneUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SynthTabbedPaneUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/synth/SynthTabbedPaneUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void update(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;I)Ljavax/swing/plaf/synth/SynthContext;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext getContext(Dova.JDK.javax.swing.JComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/synth/SynthContext;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext getContext(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/synth/Region;I)Ljavax/swing/plaf/synth/SynthContext;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext getContext(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.synth.Region arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;", "static")]
	public static Dova.JDK.javax.swing.JTabbedPane access_400(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;", "static")]
	public static Dova.JDK.javax.swing.JTabbedPane access_100(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;", "static")]
	public static Dova.JDK.javax.swing.JTabbedPane access_200(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;", "static")]
	public static Dova.JDK.javax.swing.JTabbedPane access_300(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;ILjava/awt/Font;Ljava/awt/FontMetrics;ILjava/lang/String;Ljava/awt/Rectangle;Z)V", "private")]
	public void paintText(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, Dova.JDK.java.awt.Font arg3, Dova.JDK.java.awt.FontMetrics arg4, int arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.awt.Rectangle arg7, bool arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;", "static")]
	public static Dova.JDK.javax.swing.JTabbedPane access_000(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/LayoutManager;", "protected")]
	public Dova.JDK.java.awt.LayoutManager createLayoutManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.LayoutManager>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/JButton;", "protected")]
	public Dova.JDK.javax.swing.JButton createScrollButton(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(IIZ)I", "protected")]
	public int getTabLabelShiftX(int arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IIZ)I", "protected")]
	public int getTabLabelShiftY(int arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureCurrentLayout()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool scrollableTabLayoutEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IILjava/awt/Rectangle;)V", "private")]
	public void paintTabArea(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3, Dova.JDK.java.awt.Rectangle arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;II)V", "protected")]
	public void paintTabArea(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;II)V", "private")]
	public void paintContentBorder(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IZZZZ)V", "private")]
	public void updateTabContext(int arg0, bool arg1, bool arg2, bool arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;I[Ljava/awt/Rectangle;ILjava/awt/Rectangle;Ljava/awt/Rectangle;)V", "private")]
	public void paintTab(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, JavaArray<Dova.JDK.java.awt.Rectangle> arg3, int arg4, Dova.JDK.java.awt.Rectangle arg5, Dova.JDK.java.awt.Rectangle arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void setRolloverTab(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;ILjava/awt/FontMetrics;ILjava/lang/String;Ljavax/swing/Icon;Ljava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;Z)V", "private")]
	public void layoutLabel(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, int arg1, Dova.JDK.java.awt.FontMetrics arg2, int arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.javax.swing.Icon arg5, Dova.JDK.java.awt.Rectangle arg6, Dova.JDK.java.awt.Rectangle arg7, Dova.JDK.java.awt.Rectangle arg8, bool arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(II)Ljava/awt/Insets;", "protected")]
	public Dova.JDK.java.awt.Insets getTabInsets(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("(IILjava/awt/FontMetrics;)I", "protected")]
	public int calculateTabWidth(int arg0, int arg1, Dova.JDK.java.awt.FontMetrics arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int calculateMaxTabHeight(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int calculateMaxTabWidth(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;", "static")]
	public static Dova.JDK.javax.swing.JTabbedPane access_500(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;", "static")]
	public static Dova.JDK.javax.swing.JTabbedPane access_600(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;", "static")]
	public static Dova.JDK.javax.swing.JTabbedPane access_700(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)I", "static")]
	public static int access_800(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[I", "static")]
	public static JavaArray<int> access_900(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[I", "static")]
	public static JavaArray<int> access_1000(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)I", "static")]
	public static int access_1100(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)Ljavax/swing/JTabbedPane;", "static")]
	public static Dova.JDK.javax.swing.JTabbedPane access_1200(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[Ljava/awt/Rectangle;", "static")]
	public static JavaArray<Dova.JDK.java.awt.Rectangle> access_1300(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Rectangle>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[Ljava/awt/Rectangle;", "static")]
	public static JavaArray<Dova.JDK.java.awt.Rectangle> access_1400(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Rectangle>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[Ljava/awt/Rectangle;", "static")]
	public static JavaArray<Dova.JDK.java.awt.Rectangle> access_1500(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Rectangle>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTabbedPaneUI;)[Ljava/awt/Rectangle;", "static")]
	public static JavaArray<Dova.JDK.java.awt.Rectangle> access_1600(Dova.JDK.javax.swing.plaf.synth.SynthTabbedPaneUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.Rectangle>>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40]);
	}

	[JniSignatureAttribute("(Ljavax/swing/JTabbedPane;)V", "private")]
	public void updateStyle(Dova.JDK.javax.swing.JTabbedPane arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallListeners()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43]);
	}

	[JniSignatureAttribute("()Ljava/awt/event/MouseListener;", "protected")]
	public Dova.JDK.java.awt.@event.MouseListener createMouseListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V", "public")]
	public void paintBorder(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "private")]
	public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/FontMetrics;", "protected")]
	public Dova.JDK.java.awt.FontMetrics getFontMetrics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;)V", "protected")]
	public void paint(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int getBaseline(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
	public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthTabbedPaneUI$SynthScrollableTabButton;", "private static")]
	public partial class SynthScrollableTabButton
		: Dova.JDK.javax.swing.plaf.synth.SynthArrowButton
		, Dova.JDK.javax.swing.plaf.UIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SynthScrollableTabButton()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/synth/SynthTabbedPaneUI$SynthScrollableTabButton;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SynthScrollableTabButton(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "public")]
		public SynthScrollableTabButton(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/synth/SynthTabbedPaneUI$SynthScrollableTabButton;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
