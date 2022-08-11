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

[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifButtonUI;", "public")]
public partial class MotifButtonUI
	: Dova.JDK.javax.swing.plaf.basic.BasicButtonUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MotifButtonUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifButtonUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectColor", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaults_initialized", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MOTIF_BUTTON_UI_KEY", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillContentArea", "(Ljava/awt/Graphics;Ljavax/swing/AbstractButton;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectColor", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintButtonPressed", "(Ljava/awt/Graphics;Ljavax/swing/AbstractButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallDefaults", "(Ljavax/swing/AbstractButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintFocus", "(Ljava/awt/Graphics;Ljavax/swing/AbstractButton;Ljava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "(Ljavax/swing/AbstractButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createButtonListener", "(Ljavax/swing/AbstractButton;)Ljavax/swing/plaf/basic/BasicButtonListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;Ljava/awt/Rectangle;)V"));
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "protected")]
	public Dova.JDK.java.awt.Color selectColor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool defaults_initialized_Property
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

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object MOTIF_BUTTON_UI_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MotifButtonUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MotifButtonUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifButtonUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/AbstractButton;Ljava/awt/Color;)V", "protected")]
	public void fillContentArea(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.AbstractButton arg1, Dova.JDK.java.awt.Color arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "protected")]
	public Dova.JDK.java.awt.Color getSelectColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/AbstractButton;)V", "protected")]
	public void paintButtonPressed(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.AbstractButton arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)V", "protected")]
	public void uninstallDefaults(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/AbstractButton;Ljava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;)V", "protected")]
	public void paintFocus(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.AbstractButton arg1, Dova.JDK.java.awt.Rectangle arg2, Dova.JDK.java.awt.Rectangle arg3, Dova.JDK.java.awt.Rectangle arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)V", "public")]
	public void installDefaults(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;)Ljavax/swing/plaf/basic/BasicButtonListener;", "protected")]
	public Dova.JDK.javax.swing.plaf.basic.BasicButtonListener createButtonListener(Dova.JDK.javax.swing.AbstractButton arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicButtonListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;Ljava/awt/Rectangle;)V", "protected")]
	public void paintIcon(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1, Dova.JDK.java.awt.Rectangle arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}
}
