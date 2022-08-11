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

[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthGraphicsUtils;", "public")]
public partial class SynthGraphicsUtils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SynthGraphicsUtils()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/synth/SynthGraphicsUtils;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paintIconR", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paintTextR", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paintViewR", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paintInsets", "Ljava/awt/Insets;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iconR", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textR", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "viewR", "Ljava/awt/Rectangle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "viewSizingInsets", "Ljava/awt/Insets;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintBackground", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintBackground", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Font;Ljava/lang/String;Ljavax/swing/Icon;IIIIII)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeStringWidth", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Font;Ljava/awt/FontMetrics;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintText", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljava/lang/String;Ljava/awt/Rectangle;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintText", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljava/lang/String;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintText", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljava/lang/String;Ljavax/swing/Icon;IIIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintText", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawLine", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/lang/Object;Ljava/awt/Graphics;IIIILjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawLine", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/lang/Object;Ljava/awt/Graphics;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutText", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "applyInsets", "(Ljava/awt/Rectangle;Ljava/awt/Insets;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintMenuItem", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintCheckIcon", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintAccText", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintArrowIcon", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumCharHeight", "(Ljavax/swing/plaf/synth/SynthContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPreferredMenuItemSize", "(Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/JComponent;Ljavax/swing/Icon;Ljavax/swing/Icon;ILjava/lang/String;ZLjava/lang/String;)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paint", "(Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljavax/swing/Icon;Ljavax/swing/Icon;Ljava/lang/String;ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSize", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Font;Ljava/lang/String;Ljavax/swing/Icon;IIIIII)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Font;Ljava/lang/String;Ljavax/swing/Icon;IIIIII)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintIcon", "(Ljavax/swing/Icon;Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getIconWidth", "(Ljavax/swing/Icon;Ljavax/swing/plaf/synth/SynthContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getIconHeight", "(Ljavax/swing/Icon;Ljavax/swing/plaf/synth/SynthContext;)I"));
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle paintIconR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle paintTextR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle paintViewR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "private")]
	public Dova.JDK.java.awt.Insets paintInsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle iconR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle textR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Rectangle;", "private")]
	public Dova.JDK.java.awt.Rectangle viewR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "private")]
	public Dova.JDK.java.awt.Insets viewSizingInsets_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SynthGraphicsUtils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SynthGraphicsUtils() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/synth/SynthGraphicsUtils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "static")]
	public static void paintBackground(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, Dova.JDK.javax.swing.JComponent arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;)V", "static")]
	public static void paintBackground(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthMenuItemLayoutHelper arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Font;Ljava/lang/String;Ljavax/swing/Icon;IIIIII)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredSize(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Font arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Font;Ljava/awt/FontMetrics;Ljava/lang/String;)I", "public")]
	public int computeStringWidth(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Font arg1, Dova.JDK.java.awt.FontMetrics arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljava/lang/String;Ljava/awt/Rectangle;I)V", "public")]
	public void paintText(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.awt.Rectangle arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljava/lang/String;III)V", "public")]
	public void paintText(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljava/lang/String;Ljavax/swing/Icon;IIIIIII)V", "public")]
	public void paintText(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V", "static")]
	public static void paintText(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthMenuItemLayoutHelper arg1, Dova.JDK.sun.swing.MenuItemLayoutHelper.LayoutResult arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/lang/Object;Ljava/awt/Graphics;IIIILjava/lang/Object;)V", "public")]
	public void drawLine(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.awt.Graphics arg2, int arg3, int arg4, int arg5, int arg6, Dova.JDK.java.lang.Object arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/lang/Object;Ljava/awt/Graphics;IIII)V", "public")]
	public void drawLine(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.awt.Graphics arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String layoutText(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.FontMetrics arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, Dova.JDK.java.awt.Rectangle arg8, Dova.JDK.java.awt.Rectangle arg9, Dova.JDK.java.awt.Rectangle arg10, int arg11)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;Ljava/awt/Insets;Z)V", "static")]
	public static void applyInsets(Dova.JDK.java.awt.Rectangle arg0, Dova.JDK.java.awt.Insets arg1, bool arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V", "static")]
	public static void paintMenuItem(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthMenuItemLayoutHelper arg1, Dova.JDK.sun.swing.MenuItemLayoutHelper.LayoutResult arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V", "static")]
	public static void paintCheckIcon(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthMenuItemLayoutHelper arg1, Dova.JDK.sun.swing.MenuItemLayoutHelper.LayoutResult arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V", "static")]
	public static void paintAccText(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthMenuItemLayoutHelper arg1, Dova.JDK.sun.swing.MenuItemLayoutHelper.LayoutResult arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V", "static")]
	public static void paintArrowIcon(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthMenuItemLayoutHelper arg1, Dova.JDK.sun.swing.MenuItemLayoutHelper.LayoutResult arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;)I", "public")]
	public int getMaximumCharHeight(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/JComponent;Ljavax/swing/Icon;Ljavax/swing/Icon;ILjava/lang/String;ZLjava/lang/String;)Ljava/awt/Dimension;", "static")]
	public static Dova.JDK.java.awt.Dimension getPreferredMenuItemSize(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.JComponent arg2, Dova.JDK.javax.swing.Icon arg3, Dova.JDK.javax.swing.Icon arg4, int arg5, Dova.JDK.java.lang.String arg6, bool arg7, Dova.JDK.java.lang.String arg8)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;Ljavax/swing/Icon;Ljavax/swing/Icon;Ljava/lang/String;ILjava/lang/String;)V", "static")]
	public static void paint(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.java.awt.Graphics arg2, Dova.JDK.javax.swing.Icon arg3, Dova.JDK.javax.swing.Icon arg4, Dova.JDK.java.lang.String arg5, int arg6, Dova.JDK.java.lang.String arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Font;Ljava/lang/String;Ljavax/swing/Icon;IIIIII)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMaximumSize(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Font arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Font;Ljava/lang/String;Ljavax/swing/Icon;IIIIII)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Font arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/Icon;Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V", "public static")]
	public static void paintIcon(Dova.JDK.javax.swing.Icon arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.java.awt.Graphics arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V", "static")]
	public static void paintIcon(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthMenuItemLayoutHelper arg1, Dova.JDK.sun.swing.MenuItemLayoutHelper.LayoutResult arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/Icon;Ljavax/swing/plaf/synth/SynthContext;)I", "public static")]
	public static int getIconWidth(Dova.JDK.javax.swing.Icon arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/Icon;Ljavax/swing/plaf/synth/SynthContext;)I", "public static")]
	public static int getIconHeight(Dova.JDK.javax.swing.Icon arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthGraphicsUtils$SynthIconWrapper;", "private static")]
	public partial class SynthIconWrapper
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.Icon
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SynthIconWrapper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/synth/SynthGraphicsUtils$SynthIconWrapper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHE", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "synthIcon", "Ljavax/swing/plaf/synth/SynthIcon;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Ljavax/swing/plaf/synth/SynthContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/synth/SynthIcon;Ljavax/swing/plaf/synth/SynthContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljavax/swing/plaf/synth/SynthIcon;Ljavax/swing/plaf/synth/SynthContext;)Ljavax/swing/plaf/synth/SynthGraphicsUtils$SynthIconWrapper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljavax/swing/plaf/synth/SynthIcon;Ljavax/swing/plaf/synth/SynthContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "release", "(Ljavax/swing/plaf/synth/SynthGraphicsUtils$SynthIconWrapper;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconHeight", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private static final")]
		public static Dova.JDK.java.util.List CACHE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthIcon;", "private")]
		public Dova.JDK.javax.swing.plaf.synth.SynthIcon synthIcon_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthIcon>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthContext;", "private")]
		public Dova.JDK.javax.swing.plaf.synth.SynthContext context_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SynthIconWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthIcon;Ljavax/swing/plaf/synth/SynthContext;)V", "")]
		public SynthIconWrapper(Dova.JDK.javax.swing.plaf.synth.SynthIcon arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/synth/SynthGraphicsUtils$SynthIconWrapper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthIcon;Ljavax/swing/plaf/synth/SynthContext;)Ljavax/swing/plaf/synth/SynthGraphicsUtils$SynthIconWrapper;", "static")]
		public static Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils.SynthIconWrapper get(Dova.JDK.javax.swing.plaf.synth.SynthIcon arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils.SynthIconWrapper>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthIcon;Ljavax/swing/plaf/synth/SynthContext;)V", "")]
		public void reset(Dova.JDK.javax.swing.plaf.synth.SynthIcon arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthGraphicsUtils$SynthIconWrapper;)V", "static")]
		public static void release(Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils.SynthIconWrapper arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
		public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}
	}
}
