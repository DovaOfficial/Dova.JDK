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

namespace Dova.JDK.sun.print;

[JniSignatureAttribute("Lsun/print/ProxyGraphics2D;", "public")]
public partial class ProxyGraphics2D
	: Dova.JDK.java.awt.Graphics2D
	, Dova.JDK.java.awt.print.PrinterGraphics
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ProxyGraphics2D()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ProxyGraphics2D;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mGraphics", "Ljava/awt/Graphics2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mPrinterJob", "Ljava/awt/print/PrinterJob;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Graphics2D;Ljava/awt/print/PrinterJob;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finalize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scale", "(DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fill", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDelegate", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "()Ljava/awt/Graphics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rotate", "(DDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rotate", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColor", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hit", "(Ljava/awt/Rectangle;Ljava/awt/Shape;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFont", "(Ljava/awt/Font;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDelegate", "()Ljava/awt/Graphics2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawLine", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPolygon", "([I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillPolygon", "([I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaintMode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setXORMode", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyArea", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRoundRect", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRoundRect", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawOval", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillOval", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawArc", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillArc", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPolyline", "([I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComposite", "()Ljava/awt/Composite;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStroke", "()Ljava/awt/Stroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStroke", "(Ljava/awt/Stroke;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaint", "()Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaint", "(Ljava/awt/Paint;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClip", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClip", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClip", "()Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrinterJob", "()Ljava/awt/print/PrinterJob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClipBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clip", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clipRect", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearRect", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColor", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setComposite", "(Ljava/awt/Composite;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRect", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransform", "()Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTransform", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontRenderContext", "()Ljava/awt/font/FontRenderContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRenderingHint", "(Ljava/awt/RenderingHints$Key;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IILjava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IIIILjava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IIIIIIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IIIIIIIILjava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/lang/String;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/text/AttributedCharacterIterator;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/text/AttributedCharacterIterator;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderingHint", "(Ljava/awt/RenderingHints$Key;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRenderedImage", "(Ljava/awt/image/RenderedImage;Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawGlyphVector", "(Ljava/awt/font/GlyphVector;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shear", "(DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needToCopyBgColorImage", "(Ljava/awt/Image;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferedImageCopy", "(Ljava/awt/Image;Ljava/awt/Color;)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRenderingHints", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRenderingHints", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderingHints", "()Ljava/awt/RenderingHints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeviceConfiguration", "()Ljava/awt/GraphicsConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRenderableImage", "(Ljava/awt/image/renderable/RenderableImage;Ljava/awt/geom/AffineTransform;)V"));
	}

	[JniSignatureAttribute("Ljava/awt/Graphics2D;", "")]
	public Dova.JDK.java.awt.Graphics2D mGraphics_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/print/PrinterJob;", "")]
	public Dova.JDK.java.awt.print.PrinterJob mPrinterJob_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PrinterJob>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ProxyGraphics2D(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;Ljava/awt/print/PrinterJob;)V", "public")]
	public ProxyGraphics2D(Dova.JDK.java.awt.Graphics2D arg0, Dova.JDK.java.awt.print.PrinterJob arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/print/ProxyGraphics2D;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void finalize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(DD)V", "public")]
	public void scale(double arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public")]
	public void fill(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
	public void transform(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "public")]
	public void setDelegate(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Graphics;", "public")]
	public Dova.JDK.java.awt.Graphics create()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics>(ret);
	}

	[JniSignatureAttribute("(DDD)V", "public")]
	public void rotate(double arg0, double arg1, double arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(D)V", "public")]
	public void rotate(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setColor(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;Ljava/awt/Shape;Z)Z", "public")]
	public bool hit(Dova.JDK.java.awt.Rectangle arg0, Dova.JDK.java.awt.Shape arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)V", "public")]
	public void setFont(Dova.JDK.java.awt.Font arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Graphics2D;", "public")]
	public Dova.JDK.java.awt.Graphics2D getDelegate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics2D>(ret);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void drawLine(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([I[II)V", "public")]
	public void drawPolygon(JavaArray<int> arg0, JavaArray<int> arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([I[II)V", "public")]
	public void fillPolygon(JavaArray<int> arg0, JavaArray<int> arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "public")]
	public void setPaintMode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setXORMode(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public void copyArea(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public void drawRoundRect(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public void fillRoundRect(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void drawOval(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void fillOval(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public void drawArc(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public void fillArc(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("([I[II)V", "public")]
	public void drawPolyline(JavaArray<int> arg0, JavaArray<int> arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/awt/Composite;", "public")]
	public Dova.JDK.java.awt.Composite getComposite()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Composite>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Stroke;", "public")]
	public Dova.JDK.java.awt.Stroke getStroke()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Stroke>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Stroke;)V", "public")]
	public void setStroke(Dova.JDK.java.awt.Stroke arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Paint;", "public")]
	public Dova.JDK.java.awt.Paint getPaint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Paint;)V", "public")]
	public void setPaint(Dova.JDK.java.awt.Paint arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setBackground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Font;", "public")]
	public Dova.JDK.java.awt.Font getFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void translate(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(DD)V", "public")]
	public void translate(double arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public")]
	public void setClip(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void setClip(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getClip()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public")]
	public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/print/PrinterJob;", "public")]
	public Dova.JDK.java.awt.print.PrinterJob getPrinterJob()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PrinterJob>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getClipBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public")]
	public void clip(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void clipRect(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void clearRect(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Composite;)V", "public")]
	public void setComposite(Dova.JDK.java.awt.Composite arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void fillRect(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/AffineTransform;", "public")]
	public Dova.JDK.java.awt.geom.AffineTransform getTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
	public void setTransform(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/font/FontRenderContext;", "public")]
	public Dova.JDK.java.awt.font.FontRenderContext getFontRenderContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.FontRenderContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/RenderingHints$Key;Ljava/lang/Object;)V", "public")]
	public void setRenderingHint(Dova.JDK.java.awt.RenderingHints.Key arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, Dova.JDK.java.awt.Color arg3, Dova.JDK.java.awt.image.ImageObserver arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;II)V", "public")]
	public void drawImage(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.image.BufferedImageOp arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IILjava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, Dova.JDK.java.awt.image.ImageObserver arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIILjava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, Dova.JDK.java.awt.image.ImageObserver arg5)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIIIIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, Dova.JDK.java.awt.Color arg9, Dova.JDK.java.awt.image.ImageObserver arg10)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.image.ImageObserver arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, Dova.JDK.java.awt.Color arg5, Dova.JDK.java.awt.image.ImageObserver arg6)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIIIIIILjava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, Dova.JDK.java.awt.image.ImageObserver arg9)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "public")]
	public void drawString(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;FF)V", "public")]
	public void drawString(Dova.JDK.java.lang.String arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/text/AttributedCharacterIterator;FF)V", "public")]
	public void drawString(Dova.JDK.java.text.AttributedCharacterIterator arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/text/AttributedCharacterIterator;II)V", "public")]
	public void drawString(Dova.JDK.java.text.AttributedCharacterIterator arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public")]
	public void draw(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/RenderingHints$Key;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getRenderingHint(Dova.JDK.java.awt.RenderingHints.Key arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;Ljava/awt/geom/AffineTransform;)V", "public")]
	public void drawRenderedImage(Dova.JDK.java.awt.image.RenderedImage arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/font/GlyphVector;FF)V", "public")]
	public void drawGlyphVector(Dova.JDK.java.awt.font.GlyphVector arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(DD)V", "public")]
	public void shear(double arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;)Z", "private")]
	public bool needToCopyBgColorImage(Dova.JDK.java.awt.Image arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/Color;)Ljava/awt/image/BufferedImage;", "private")]
	public Dova.JDK.java.awt.image.BufferedImage getBufferedImageCopy(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.Color arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
	public void setRenderingHints(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
	public void addRenderingHints(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/RenderingHints;", "public")]
	public Dova.JDK.java.awt.RenderingHints getRenderingHints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.RenderingHints>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsConfiguration;", "public")]
	public Dova.JDK.java.awt.GraphicsConfiguration getDeviceConfiguration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/renderable/RenderableImage;Ljava/awt/geom/AffineTransform;)V", "public")]
	public void drawRenderableImage(Dova.JDK.java.awt.image.renderable.RenderableImage arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
	}
}
