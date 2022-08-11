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

[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicGraphicsUtils;", "public")]
public partial class BasicGraphicsUtils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicGraphicsUtils()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicGraphicsUtils;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GROOVE_INSETS", "Ljava/awt/Insets;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ETCHED_INSETS", "Ljava/awt/Insets;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawLoweredBezel", "(Ljava/awt/Graphics;IIIILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawEtchedRect", "(Ljava/awt/Graphics;IIIILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEtchedInsets", "()Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawGroove", "(Ljava/awt/Graphics;IIIILjava/awt/Color;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getGrooveInsets", "()Ljava/awt/Insets;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawBezel", "(Ljava/awt/Graphics;IIIIZZLjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClippedString", "(Ljavax/swing/JComponent;Ljava/awt/FontMetrics;Ljava/lang/String;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStringWidth", "(Ljavax/swing/JComponent;Ljava/awt/FontMetrics;Ljava/lang/String;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLeftToRight", "(Ljava/awt/Component;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawStringUnderlineCharAt", "(Ljavax/swing/JComponent;Ljava/awt/Graphics2D;Ljava/lang/String;IFF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawStringUnderlineCharAt", "(Ljava/awt/Graphics;Ljava/lang/String;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPreferredButtonSize", "(Ljavax/swing/AbstractButton;I)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMenuShortcutKeyDown", "(Ljava/awt/event/InputEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawDashedRect", "(Ljava/awt/Graphics;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawString", "(Ljava/awt/Graphics;Ljava/lang/String;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawString", "(Ljavax/swing/JComponent;Ljava/awt/Graphics2D;Ljava/lang/String;FF)V"));
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "private static final")]
	public static Dova.JDK.java.awt.Insets GROOVE_INSETS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "private static final")]
	public static Dova.JDK.java.awt.Insets ETCHED_INSETS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BasicGraphicsUtils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BasicGraphicsUtils() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicGraphicsUtils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIIILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V", "public static")]
	public static void drawLoweredBezel(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, Dova.JDK.java.awt.Color arg5, Dova.JDK.java.awt.Color arg6, Dova.JDK.java.awt.Color arg7, Dova.JDK.java.awt.Color arg8)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIIILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V", "public static")]
	public static void drawEtchedRect(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, Dova.JDK.java.awt.Color arg5, Dova.JDK.java.awt.Color arg6, Dova.JDK.java.awt.Color arg7, Dova.JDK.java.awt.Color arg8)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("()Ljava/awt/Insets;", "public static")]
	public static Dova.JDK.java.awt.Insets getEtchedInsets()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIIILjava/awt/Color;Ljava/awt/Color;)V", "public static")]
	public static void drawGroove(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, Dova.JDK.java.awt.Color arg5, Dova.JDK.java.awt.Color arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("()Ljava/awt/Insets;", "public static")]
	public static Dova.JDK.java.awt.Insets getGrooveInsets()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIIIZZLjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V", "public static")]
	public static void drawBezel(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, bool arg5, bool arg6, Dova.JDK.java.awt.Color arg7, Dova.JDK.java.awt.Color arg8, Dova.JDK.java.awt.Color arg9, Dova.JDK.java.awt.Color arg10)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/awt/FontMetrics;Ljava/lang/String;I)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getClippedString(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.awt.FontMetrics arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/awt/FontMetrics;Ljava/lang/String;)F", "public static")]
	public static float getStringWidth(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.awt.FontMetrics arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Z", "static")]
	public static bool isLeftToRight(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/awt/Graphics2D;Ljava/lang/String;IFF)V", "public static")]
	public static void drawStringUnderlineCharAt(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.awt.Graphics2D arg1, Dova.JDK.java.lang.String arg2, int arg3, float arg4, float arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/lang/String;III)V", "public static")]
	public static void drawStringUnderlineCharAt(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;I)Ljava/awt/Dimension;", "public static")]
	public static Dova.JDK.java.awt.Dimension getPreferredButtonSize(Dova.JDK.javax.swing.AbstractButton arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/InputEvent;)Z", "static")]
	public static bool isMenuShortcutKeyDown(Dova.JDK.java.awt.@event.InputEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIII)V", "public static")]
	public static void drawDashedRect(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/lang/String;III)V", "public static")]
	public static void drawString(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/awt/Graphics2D;Ljava/lang/String;FF)V", "public static")]
	public static void drawString(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.awt.Graphics2D arg1, Dova.JDK.java.lang.String arg2, float arg3, float arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
	}
}
