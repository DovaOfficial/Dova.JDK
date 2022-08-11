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

[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthButtonUI;", "public")]
public partial class SynthButtonUI
	: Dova.JDK.javax.swing.plaf.basic.BasicButtonUI
	, Dova.JDK.java.beans.PropertyChangeListener
	, Dova.JDK.javax.swing.plaf.synth.SynthUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SynthButtonUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/synth/SynthButtonUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "style", "Ljavax/swing/plaf/synth/SynthStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYNTH_BUTTON_UI_KEY", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/synth/SynthContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "(Ljavax/swing/JComponent;I)Ljavax/swing/plaf/synth/SynthContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentState", "(Ljavax/swing/JComponent;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "(Ljavax/swing/AbstractButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallDefaults", "(Ljavax/swing/AbstractButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateStyle", "(Ljavax/swing/AbstractButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "(Ljavax/swing/AbstractButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBackground", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallListeners", "(Ljavax/swing/AbstractButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextShiftOffset", "(Ljavax/swing/plaf/synth/SynthContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSynthDisabledIcon", "(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnabledIcon", "(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultIcon", "(Ljavax/swing/AbstractButton;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSynthIcon", "(Ljavax/swing/AbstractButton;I)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificIcon", "(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;Ljavax/swing/Icon;Ljavax/swing/Icon;I)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSizingIcon", "(Ljavax/swing/AbstractButton;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBorder", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIcon", "(Ljavax/swing/AbstractButton;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIcon", "(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;Ljavax/swing/Icon;I)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedIcon", "(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPressedIcon", "(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRolloverIcon", "(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSize", "(Ljavax/swing/JComponent;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseline", "(Ljavax/swing/JComponent;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthStyle;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle style_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object SYNTH_BUTTON_UI_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SynthButtonUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SynthButtonUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/synth/SynthButtonUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void update(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/synth/SynthContext;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext getContext(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;I)Ljavax/swing/plaf/synth/SynthContext;", "")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext getContext(Dova.JDK.javax.swing.JComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)I", "private")]
	public int getComponentState(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)V", "protected")]
	public void installDefaults(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)V", "protected")]
	public void uninstallDefaults(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)V", "")]
	public void updateStyle(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)V", "protected")]
	public void installListeners(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "")]
	public void paintBackground(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, Dova.JDK.javax.swing.JComponent arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)V", "protected")]
	public void uninstallListeners(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;)I", "private")]
	public int getTextShiftOffset(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon getSynthDisabledIcon(Dova.JDK.javax.swing.AbstractButton arg0, Dova.JDK.javax.swing.Icon arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon getEnabledIcon(Dova.JDK.javax.swing.AbstractButton arg0, Dova.JDK.javax.swing.Icon arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)Ljavax/swing/Icon;", "protected")]
	public Dova.JDK.javax.swing.Icon getDefaultIcon(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;I)Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon getSynthIcon(Dova.JDK.javax.swing.AbstractButton arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;Ljavax/swing/Icon;Ljavax/swing/Icon;I)Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon getSpecificIcon(Dova.JDK.javax.swing.AbstractButton arg0, Dova.JDK.javax.swing.Icon arg1, Dova.JDK.javax.swing.Icon arg2, Dova.JDK.javax.swing.Icon arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)Ljavax/swing/Icon;", "protected")]
	public Dova.JDK.javax.swing.Icon getSizingIcon(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V", "public")]
	public void paintBorder(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)Ljavax/swing/Icon;", "protected")]
	public Dova.JDK.javax.swing.Icon getIcon(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;Ljavax/swing/Icon;I)Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon getIcon(Dova.JDK.javax.swing.AbstractButton arg0, Dova.JDK.javax.swing.Icon arg1, Dova.JDK.javax.swing.Icon arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon getSelectedIcon(Dova.JDK.javax.swing.AbstractButton arg0, Dova.JDK.javax.swing.Icon arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon getPressedIcon(Dova.JDK.javax.swing.AbstractButton arg0, Dova.JDK.javax.swing.Icon arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;Ljavax/swing/Icon;)Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon getRolloverIcon(Dova.JDK.javax.swing.AbstractButton arg0, Dova.JDK.javax.swing.Icon arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;)V", "protected")]
	public void paint(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMaximumSize(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;II)I", "public")]
	public int getBaseline(Dova.JDK.javax.swing.JComponent arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
	public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}
}
