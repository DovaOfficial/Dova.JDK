/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljavax/swing/text/GlyphPainter2;", "")]
public partial class GlyphPainter2
	: Dova.JDK.javax.swing.text.GlyphView.GlyphPainter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GlyphPainter2()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/GlyphPainter2;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "layout", "Ljava/awt/font/TextLayout;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GlyphPainter2", "(Ljava/awt/font/TextLayout;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNextVisualPositionFrom", "(Ljavax/swing/text/GlyphView;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "viewToModel", "(Ljavax/swing/text/GlyphView;FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "modelToView", "(Ljavax/swing/text/GlyphView;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getHeight", "(Ljavax/swing/text/GlyphView;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPainter", "(Ljavax/swing/text/GlyphView;II)Ljavax/swing/text/GlyphView$GlyphPainter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBoundedPosition", "(Ljavax/swing/text/GlyphView;IFF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAscent", "(Ljavax/swing/text/GlyphView;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDescent", "(Ljavax/swing/text/GlyphView;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSpan", "(Ljavax/swing/text/GlyphView;IILjavax/swing/text/TabExpander;F)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "paint", "(Ljavax/swing/text/GlyphView;Ljava/awt/Graphics;Ljava/awt/Shape;II)V"));
	}

	[JniSignatureAttribute("Ljava/awt/font/TextLayout;", "")]
	public Dova.JDK.java.awt.font.TextLayout layout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.TextLayout>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GlyphPainter2(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/font/TextLayout;)V", "public")]
	public GlyphPainter2(Dova.JDK.java.awt.font.TextLayout arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/GlyphPainter2;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I", "public")]
	public int getNextVisualPositionFrom(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2, Dova.JDK.java.awt.Shape arg3, int arg4, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg5)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I", "public")]
	public int viewToModel(Dova.JDK.javax.swing.text.GlyphView arg0, float arg1, float arg2, Dova.JDK.java.awt.Shape arg3, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape modelToView(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2, Dova.JDK.java.awt.Shape arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;)F", "public")]
	public float getHeight(Dova.JDK.javax.swing.text.GlyphView arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;II)Ljavax/swing/text/GlyphView$GlyphPainter;", "public")]
	public Dova.JDK.javax.swing.text.GlyphView.GlyphPainter getPainter(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.GlyphView.GlyphPainter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;IFF)I", "public")]
	public int getBoundedPosition(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;)F", "public")]
	public float getAscent(Dova.JDK.javax.swing.text.GlyphView arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;)F", "public")]
	public float getDescent(Dova.JDK.javax.swing.text.GlyphView arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;IILjavax/swing/text/TabExpander;F)F", "public")]
	public float getSpan(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, int arg2, Dova.JDK.javax.swing.text.TabExpander arg3, float arg4)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;Ljava/awt/Graphics;Ljava/awt/Shape;II)V", "public")]
	public void paint(Dova.JDK.javax.swing.text.GlyphView arg0, Dova.JDK.java.awt.Graphics arg1, Dova.JDK.java.awt.Shape arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
	}
}
