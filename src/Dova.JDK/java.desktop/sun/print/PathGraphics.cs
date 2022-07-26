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

[JniSignatureAttribute("Lsun/print/PathGraphics;", "public abstract")]
public partial class PathGraphics
	: Dova.JDK.sun.print.ProxyGraphics2D
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PathGraphics()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/PathGraphics;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mPainter", "Ljava/awt/print/Printable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mPageFormat", "Ljava/awt/print/PageFormat;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mPageIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mCanRedraw", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printingGlyphVector", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fontMapRef", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Graphics2D;Ljava/awt/print/PrinterJob;Ljava/awt/print/Printable;Ljava/awt/print/PageFormat;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fill", "(Ljava/awt/Shape;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fill", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawLine", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPolygon", "([I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPolygon", "(Ljava/awt/Polygon;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillPolygon", "([I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillPolygon", "(Ljava/awt/Polygon;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRoundRect", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRoundRect", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawOval", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillOval", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawArc", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillArc", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPolyline", "([I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRect", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPageFormat", "()Ljava/awt/print/PageFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPageIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canDoRedraws", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deviceFill", "(Ljava/awt/geom/PathIterator;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "platformFontCount", "(Ljava/awt/Font;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferedImage", "(Ljava/awt/Image;)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompositing", "(Ljava/awt/Composite;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasTransparentPixels", "(Ljava/awt/image/BufferedImage;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBitmaskTransparency", "(Ljava/awt/image/BufferedImage;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawBitmaskImage", "(Ljava/awt/image/BufferedImage;Ljava/awt/geom/AffineTransform;Ljava/awt/Color;IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canDrawStringToWidth", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImageToPlatform", "(Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/Color;IIIIZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redrawRegion", "(Ljava/awt/geom/Rectangle2D;DDLjava/awt/Shape;Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deviceFrameRect", "(IIIILjava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deviceDrawLine", "(IIIILjava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deviceFillRect", "(IIIILjava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deviceClip", "(Ljava/awt/geom/PathIterator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrintable", "()Ljava/awt/print/Printable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearRect", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRect", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IILjava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IIIILjava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IIIIIIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;IIIIIIIILjava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/text/AttributedCharacterIterator;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/text/AttributedCharacterIterator;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/lang/String;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/lang/String;FFLjava/awt/Font;Ljava/awt/font/FontRenderContext;F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printedSimpleGlyphVector", "(Ljava/awt/font/GlyphVector;FF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printGlyphVector", "(Ljava/awt/font/GlyphVector;FF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getGlyphToCharMapForFont", "(Lsun/font/Font2D;)[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "samePositions", "(Ljava/awt/font/GlyphVector;[I[I[F)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRenderedImage", "(Ljava/awt/image/RenderedImage;Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawGlyphVector", "(Ljava/awt/font/GlyphVector;FF)V"));
	}

	[JniSignatureAttribute("Ljava/awt/print/Printable;", "private")]
	public Dova.JDK.java.awt.print.Printable mPainter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.Printable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/print/PageFormat;", "private")]
	public Dova.JDK.java.awt.print.PageFormat mPageFormat_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PageFormat>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int mPageIndex_Property
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
	public bool mCanRedraw_Property
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

	[JniSignatureAttribute("Z", "protected")]
	public bool printingGlyphVector_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "protected static")]
	public static Dova.JDK.java.lang.@ref.SoftReference fontMapRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PathGraphics(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;Ljava/awt/print/PrinterJob;Ljava/awt/print/Printable;Ljava/awt/print/PageFormat;IZ)V", "protected")]
	public PathGraphics(Dova.JDK.java.awt.Graphics2D arg0, Dova.JDK.java.awt.print.PrinterJob arg1, Dova.JDK.java.awt.print.Printable arg2, Dova.JDK.java.awt.print.PageFormat arg3, int arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/print/PathGraphics;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Shape;Ljava/awt/Color;)V", "public")]
	public void fill(Dova.JDK.java.awt.Shape arg0, Dova.JDK.java.awt.Color arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public")]
	public void fill(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void drawLine(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([I[II)V", "public")]
	public void drawPolygon(JavaArray<int> arg0, JavaArray<int> arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Polygon;)V", "public")]
	public void drawPolygon(Dova.JDK.java.awt.Polygon arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("([I[II)V", "public")]
	public void fillPolygon(JavaArray<int> arg0, JavaArray<int> arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Polygon;)V", "public")]
	public void fillPolygon(Dova.JDK.java.awt.Polygon arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public void drawRoundRect(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public void fillRoundRect(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void drawOval(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void fillOval(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public void drawArc(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(IIIIII)V", "public")]
	public void fillArc(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("([I[II)V", "public")]
	public void drawPolyline(JavaArray<int> arg0, JavaArray<int> arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void drawRect(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/print/PageFormat;", "protected")]
	public Dova.JDK.java.awt.print.PageFormat getPageFormat()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PageFormat>(ret);
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getPageIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canDoRedraws()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/PathIterator;Ljava/awt/Color;)V", "protected abstract")]
	public void deviceFill(Dova.JDK.java.awt.geom.PathIterator arg0, Dova.JDK.java.awt.Color arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;Ljava/lang/String;)I", "protected")]
	public int platformFontCount(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;)Ljava/awt/image/BufferedImage;", "protected")]
	public Dova.JDK.java.awt.image.BufferedImage getBufferedImage(Dova.JDK.java.awt.Image arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Composite;)Z", "protected")]
	public bool isCompositing(Dova.JDK.java.awt.Composite arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)Z", "protected")]
	public bool hasTransparentPixels(Dova.JDK.java.awt.image.BufferedImage arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)Z", "protected")]
	public bool isBitmaskTransparency(Dova.JDK.java.awt.image.BufferedImage arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/geom/AffineTransform;Ljava/awt/Color;IIII)Z", "protected")]
	public bool drawBitmaskImage(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.Color arg2, int arg3, int arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool canDrawStringToWidth()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/Color;IIIIZ)Z", "protected abstract")]
	public bool drawImageToPlatform(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.Color arg2, int arg3, int arg4, int arg5, int arg6, bool arg7)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;DDLjava/awt/Shape;Ljava/awt/geom/AffineTransform;)V", "public abstract")]
	public void redrawRegion(Dova.JDK.java.awt.geom.Rectangle2D arg0, double arg1, double arg2, Dova.JDK.java.awt.Shape arg3, Dova.JDK.java.awt.geom.AffineTransform arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IIIILjava/awt/Color;)V", "protected abstract")]
	public void deviceFrameRect(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.Color arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IIIILjava/awt/Color;)V", "protected abstract")]
	public void deviceDrawLine(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.Color arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IIIILjava/awt/Color;)V", "protected abstract")]
	public void deviceFillRect(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.awt.Color arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/PathIterator;)V", "protected abstract")]
	public void deviceClip(Dova.JDK.java.awt.geom.PathIterator arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/print/Printable;", "protected")]
	public Dova.JDK.java.awt.print.Printable getPrintable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.Printable>(ret);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void clearRect(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void fillRect(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IILjava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, Dova.JDK.java.awt.image.ImageObserver arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;II)V", "public")]
	public void drawImage(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.image.BufferedImageOp arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, Dova.JDK.java.awt.Color arg5, Dova.JDK.java.awt.image.ImageObserver arg6)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, Dova.JDK.java.awt.Color arg3, Dova.JDK.java.awt.image.ImageObserver arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIILjava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, Dova.JDK.java.awt.image.ImageObserver arg5)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.image.ImageObserver arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIIIIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, Dova.JDK.java.awt.Color arg9, Dova.JDK.java.awt.image.ImageObserver arg10)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;IIIIIIIILjava/awt/image/ImageObserver;)Z", "public")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, Dova.JDK.java.awt.image.ImageObserver arg9)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/text/AttributedCharacterIterator;II)V", "public")]
	public void drawString(Dova.JDK.java.text.AttributedCharacterIterator arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/text/AttributedCharacterIterator;FF)V", "public")]
	public void drawString(Dova.JDK.java.text.AttributedCharacterIterator arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "public")]
	public void drawString(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;FF)V", "public")]
	public void drawString(Dova.JDK.java.lang.String arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;FFLjava/awt/Font;Ljava/awt/font/FontRenderContext;F)V", "protected")]
	public void drawString(Dova.JDK.java.lang.String arg0, float arg1, float arg2, Dova.JDK.java.awt.Font arg3, Dova.JDK.java.awt.font.FontRenderContext arg4, float arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public")]
	public void draw(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/font/GlyphVector;FF)Z", "")]
	public bool printedSimpleGlyphVector(Dova.JDK.java.awt.font.GlyphVector arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/font/GlyphVector;FF)Z", "protected")]
	public bool printGlyphVector(Dova.JDK.java.awt.font.GlyphVector arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/Font2D;)[C", "private static")]
	public static JavaArray<char> getGlyphToCharMapForFont(Dova.JDK.sun.font.Font2D arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/font/GlyphVector;[I[I[F)Z", "private")]
	public bool samePositions(Dova.JDK.java.awt.font.GlyphVector arg0, JavaArray<int> arg1, JavaArray<int> arg2, JavaArray<float> arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;Ljava/awt/geom/AffineTransform;)V", "public")]
	public void drawRenderedImage(Dova.JDK.java.awt.image.RenderedImage arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/font/GlyphVector;FF)V", "public")]
	public void drawGlyphVector(Dova.JDK.java.awt.font.GlyphVector arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2);
	}
}
