/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/Utilities;", "public")]
public partial class Utilities
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Utilities()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/Utilities;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Utilities", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNextVisualPositionFrom", "(Ljavax/swing/text/View;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "paintComposedText", "(Ljava/awt/Graphics;Ljava/awt/Rectangle;Ljavax/swing/text/GlyphView;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getBreakLocation", "(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;IILjavax/swing/text/TabExpander;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getBreakLocation", "(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getBreakLocation", "(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getJComponent", "(Ljavax/swing/text/View;)Ljavax/swing/JComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isComposedTextAttributeDefined", "(Ljavax/swing/text/AttributeSet;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isComposedTextElement", "(Ljavax/swing/text/Document;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isComposedTextElement", "(Ljavax/swing/text/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextWidth", "(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;ILjavax/swing/text/TabExpander;I[I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextWidth", "(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FLjavax/swing/text/TabExpander;I[I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextWidth", "(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FLjavax/swing/text/TabExpander;I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextWidth", "(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;ILjavax/swing/text/TabExpander;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextWidth", "(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FLjavax/swing/text/TabExpander;I[IZ)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drawComposedText", "(Ljavax/swing/text/View;Ljavax/swing/text/AttributeSet;Ljava/awt/Graphics;FFII)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drawComposedText", "(Ljavax/swing/text/View;Ljavax/swing/text/AttributeSet;Ljava/awt/Graphics;IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drawComposedText", "(Ljavax/swing/text/View;Ljavax/swing/text/AttributeSet;Ljava/awt/Graphics;FFIIZ)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drawTabbedText", "(Ljavax/swing/text/Segment;IILjava/awt/Graphics;Ljavax/swing/text/TabExpander;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drawTabbedText", "(Ljavax/swing/text/Segment;FFLjava/awt/Graphics2D;Ljavax/swing/text/TabExpander;I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drawTabbedText", "(Ljavax/swing/text/View;Ljavax/swing/text/Segment;IILjava/awt/Graphics;Ljavax/swing/text/TabExpander;I[I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drawTabbedText", "(Ljavax/swing/text/View;Ljavax/swing/text/Segment;FFLjava/awt/Graphics;Ljavax/swing/text/TabExpander;I[IZ)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drawTabbedText", "(Ljavax/swing/text/View;Ljavax/swing/text/Segment;IILjava/awt/Graphics;Ljavax/swing/text/TabExpander;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextOffset", "(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;IILjavax/swing/text/TabExpander;I[I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextOffset", "(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;I[I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextOffset", "(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;IILjavax/swing/text/TabExpander;IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextOffset", "(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextOffset", "(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;IILjavax/swing/text/TabExpander;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTabbedTextOffset", "(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;IZ[IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getParagraphElement", "(Ljavax/swing/text/JTextComponent;I)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNextWordInParagraph", "(Ljavax/swing/text/JTextComponent;Ljavax/swing/text/Element;IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPrevWordInParagraph", "(Ljavax/swing/text/JTextComponent;Ljavax/swing/text/Element;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getWordStart", "(Ljavax/swing/text/JTextComponent;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getWordEnd", "(Ljavax/swing/text/JTextComponent;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPreviousWord", "(Ljavax/swing/text/JTextComponent;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNextWord", "(Ljavax/swing/text/JTextComponent;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getRowStart", "(Ljavax/swing/text/JTextComponent;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getRowEnd", "(Ljavax/swing/text/JTextComponent;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPositionAbove", "(Ljavax/swing/text/JTextComponent;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPositionAbove", "(Ljavax/swing/text/JTextComponent;IF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPositionAbove", "(Ljavax/swing/text/JTextComponent;IFZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPositionBelow", "(Ljavax/swing/text/JTextComponent;IF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPositionBelow", "(Ljavax/swing/text/JTextComponent;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPositionBelow", "(Ljavax/swing/text/JTextComponent;IFZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isLeftToRight", "(Ljava/awt/Component;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Utilities(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Utilities() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/Utilities;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/text/View;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I", "static")]
	public static int getNextVisualPositionFrom(Dova.JDK.javax.swing.text.View arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2, Dova.JDK.java.awt.Shape arg3, int arg4, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Rectangle;Ljavax/swing/text/GlyphView;)V", "static")]
	public static void paintComposedText(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Rectangle arg1, Dova.JDK.javax.swing.text.GlyphView arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;IILjavax/swing/text/TabExpander;I)I", "public static final")]
	public static int getBreakLocation(Dova.JDK.javax.swing.text.Segment arg0, Dova.JDK.java.awt.FontMetrics arg1, int arg2, int arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;I)I", "public static final")]
	public static int getBreakLocation(Dova.JDK.javax.swing.text.Segment arg0, Dova.JDK.java.awt.FontMetrics arg1, float arg2, float arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;IZ)I", "static final")]
	public static int getBreakLocation(Dova.JDK.javax.swing.text.Segment arg0, Dova.JDK.java.awt.FontMetrics arg1, float arg2, float arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5, bool arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)Ljavax/swing/JComponent;", "static")]
	public static Dova.JDK.javax.swing.JComponent getJComponent(Dova.JDK.javax.swing.text.View arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComponent>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;)Z", "static")]
	public static bool isComposedTextAttributeDefined(Dova.JDK.javax.swing.text.AttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Document;I)Z", "static")]
	public static bool isComposedTextElement(Dova.JDK.javax.swing.text.Document arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)Z", "static")]
	public static bool isComposedTextElement(Dova.JDK.javax.swing.text.Element arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;ILjavax/swing/text/TabExpander;I[I)I", "static final")]
	public static int getTabbedTextWidth(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Segment arg1, Dova.JDK.java.awt.FontMetrics arg2, int arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5, JavaArray<int> arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FLjavax/swing/text/TabExpander;I[I)F", "static final")]
	public static float getTabbedTextWidth(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Segment arg1, Dova.JDK.java.awt.FontMetrics arg2, float arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5, JavaArray<int> arg6)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FLjavax/swing/text/TabExpander;I)F", "public static final")]
	public static float getTabbedTextWidth(Dova.JDK.javax.swing.text.Segment arg0, Dova.JDK.java.awt.FontMetrics arg1, float arg2, Dova.JDK.javax.swing.text.TabExpander arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;ILjavax/swing/text/TabExpander;I)I", "public static final")]
	public static int getTabbedTextWidth(Dova.JDK.javax.swing.text.Segment arg0, Dova.JDK.java.awt.FontMetrics arg1, int arg2, Dova.JDK.javax.swing.text.TabExpander arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FLjavax/swing/text/TabExpander;I[IZ)F", "static final")]
	public static float getTabbedTextWidth(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Segment arg1, Dova.JDK.java.awt.FontMetrics arg2, float arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5, JavaArray<int> arg6, bool arg7)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/AttributeSet;Ljava/awt/Graphics;FFII)F", "static")]
	public static float drawComposedText(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.AttributeSet arg1, Dova.JDK.java.awt.Graphics arg2, float arg3, float arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/AttributeSet;Ljava/awt/Graphics;IIII)I", "static")]
	public static int drawComposedText(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.AttributeSet arg1, Dova.JDK.java.awt.Graphics arg2, int arg3, int arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/AttributeSet;Ljava/awt/Graphics;FFIIZ)F", "static")]
	public static float drawComposedText(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.AttributeSet arg1, Dova.JDK.java.awt.Graphics arg2, float arg3, float arg4, int arg5, int arg6, bool arg7)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;IILjava/awt/Graphics;Ljavax/swing/text/TabExpander;I)I", "public static final")]
	public static int drawTabbedText(Dova.JDK.javax.swing.text.Segment arg0, int arg1, int arg2, Dova.JDK.java.awt.Graphics arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;FFLjava/awt/Graphics2D;Ljavax/swing/text/TabExpander;I)F", "public static final")]
	public static float drawTabbedText(Dova.JDK.javax.swing.text.Segment arg0, float arg1, float arg2, Dova.JDK.java.awt.Graphics2D arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Segment;IILjava/awt/Graphics;Ljavax/swing/text/TabExpander;I[I)I", "static final")]
	public static int drawTabbedText(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Segment arg1, int arg2, int arg3, Dova.JDK.java.awt.Graphics arg4, Dova.JDK.javax.swing.text.TabExpander arg5, int arg6, JavaArray<int> arg7)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Segment;FFLjava/awt/Graphics;Ljavax/swing/text/TabExpander;I[IZ)F", "static final")]
	public static float drawTabbedText(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Segment arg1, float arg2, float arg3, Dova.JDK.java.awt.Graphics arg4, Dova.JDK.javax.swing.text.TabExpander arg5, int arg6, JavaArray<int> arg7, bool arg8)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Segment;IILjava/awt/Graphics;Ljavax/swing/text/TabExpander;I)I", "static final")]
	public static int drawTabbedText(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Segment arg1, int arg2, int arg3, Dova.JDK.java.awt.Graphics arg4, Dova.JDK.javax.swing.text.TabExpander arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;IILjavax/swing/text/TabExpander;I[I)I", "static final")]
	public static int getTabbedTextOffset(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Segment arg1, Dova.JDK.java.awt.FontMetrics arg2, int arg3, int arg4, Dova.JDK.javax.swing.text.TabExpander arg5, int arg6, JavaArray<int> arg7)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;I[I)I", "static final")]
	public static int getTabbedTextOffset(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Segment arg1, Dova.JDK.java.awt.FontMetrics arg2, float arg3, float arg4, Dova.JDK.javax.swing.text.TabExpander arg5, int arg6, JavaArray<int> arg7)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;IILjavax/swing/text/TabExpander;IZ)I", "public static final")]
	public static int getTabbedTextOffset(Dova.JDK.javax.swing.text.Segment arg0, Dova.JDK.java.awt.FontMetrics arg1, int arg2, int arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5, bool arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;IZ)I", "public static final")]
	public static int getTabbedTextOffset(Dova.JDK.javax.swing.text.Segment arg0, Dova.JDK.java.awt.FontMetrics arg1, float arg2, float arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5, bool arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;IILjavax/swing/text/TabExpander;I)I", "public static final")]
	public static int getTabbedTextOffset(Dova.JDK.javax.swing.text.Segment arg0, Dova.JDK.java.awt.FontMetrics arg1, int arg2, int arg3, Dova.JDK.javax.swing.text.TabExpander arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Segment;Ljava/awt/FontMetrics;FFLjavax/swing/text/TabExpander;IZ[IZ)I", "static final")]
	public static int getTabbedTextOffset(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Segment arg1, Dova.JDK.java.awt.FontMetrics arg2, float arg3, float arg4, Dova.JDK.javax.swing.text.TabExpander arg5, int arg6, bool arg7, JavaArray<int> arg8, bool arg9)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;I)Ljavax/swing/text/Element;", "public static final")]
	public static Dova.JDK.javax.swing.text.Element getParagraphElement(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljavax/swing/text/Element;IZ)I", "static")]
	public static int getNextWordInParagraph(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.javax.swing.text.Element arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljavax/swing/text/Element;I)I", "static")]
	public static int getPrevWordInParagraph(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.javax.swing.text.Element arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;I)I", "public static final")]
	public static int getWordStart(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;I)I", "public static final")]
	public static int getWordEnd(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;I)I", "public static final")]
	public static int getPreviousWord(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;I)I", "public static final")]
	public static int getNextWord(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;I)I", "public static final")]
	public static int getRowStart(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;I)I", "public static final")]
	public static int getRowEnd(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;II)I", "public static final")]
	public static int getPositionAbove(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;IF)I", "public static final")]
	public static int getPositionAbove(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;IFZ)I", "static final")]
	public static int getPositionAbove(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, float arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;IF)I", "public static final")]
	public static int getPositionBelow(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;II)I", "public static final")]
	public static int getPositionBelow(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;IFZ)I", "static final")]
	public static int getPositionBelow(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, float arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Z", "static")]
	public static bool isLeftToRight(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return ret;
	}
}
